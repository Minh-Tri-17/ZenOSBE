using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ZenOS.BLL.Interfaces;
using ZenOS.DAL.Models;
using ZenOS.MB;
using ZenOS.Util;

namespace ZenOS.BLL.Services
{
    public class AccountService : IAccountService
    {
        #region Infrastructure

        private readonly ZenOsContext _context;
        private readonly IConfiguration _config;
        private readonly IdentityOptions _options;

        public AccountService(ZenOsContext context, IConfiguration config, IOptions<IdentityOptions> options)
        {
            _context = context;
            _config = config;
            _options = options.Value;
        }

        #endregion

        #region Default Operations

        #endregion

        #region Custom Operations

        public async Task<APIResults<string>> Auth(UserModel request)
        {
            var username = DataHelpers.GetString(request.Username);
            var password = DataHelpers.GetString(request.Password);

            var user = await _context.Users.AsNoTracking() // Tắt cơ chế "theo dõi thay đổi" (Change Tracking) của Entity Framework
                .FirstOrDefaultAsync(s => !string.IsNullOrWhiteSpace(s.Username) && s.Username == username);
            if (user == null)
                return APIResults<string>.Failure(Messages.InvalidUsernameOrPassword); // Luôn trả ra message chung chung để tránh hacker biết được thông tin chính xác

            var checkPassword = PasswordHasher.VerifyPassword(password, DataHelpers.GetString(user.PasswordHash));
            if (checkPassword == false)
                return APIResults<string>.Failure(Messages.InvalidUsernameOrPassword); // Luôn trả ra message chung chung để tránh hacker biết được thông tin chính xác

            var employee = await _context.Employees.FirstOrDefaultAsync(s => s.Id == DataHelpers.GetGuid(user.EmployeeId));

            var id = employee != null ? employee.Id : Guid.Empty;
            var employeeName = employee != null ? employee.EmployeeName : string.Empty;

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Name, DataHelpers.GetString(user.Username)),
                new Claim(ClaimTypes.GivenName, DataHelpers.GetString(employeeName)),
                new Claim("UserID", DataHelpers.GetString(user.Id.ToString())),
                new Claim("OwnerID", DataHelpers.GetString(id.ToString())),
            };

            #region Add roleNames to claim Role

            var listUserRole = await _context.UserRoles
                .Where(s => s.UserId == user.Id)
                .Join(_context.Roles,
                    ur => ur.RoleId,
                    r => r.Id,
                    (ur, r) => r.RoleName)
                .ToListAsync();

            claims.AddRange(listUserRole.Select(roleName => new Claim(ClaimTypes.Role, DataHelpers.GetString(roleName))));

            #endregion

            var tokenKey = _config["Tokens:Key"];
            var tokenIssuer = _config["Tokens:Issuer"];

            if (string.IsNullOrEmpty(tokenKey))
                return APIResults<string>.Failure(Messages.TokenKeyNotConfigured);

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            DateTime expirationTime = request.Remember
                ? DateTime.UtcNow.AddYears(1) : DateTime.UtcNow.AddHours(1); // UtcNow để không lỗi khi server khác timezone

            var token = new JwtSecurityToken(tokenIssuer, tokenIssuer, claims,
               expires: expirationTime, signingCredentials: creds);

            return token != null
                ? APIResults<string>.Success(new JwtSecurityTokenHandler().WriteToken(token), Messages.AuthSuccess)
                : APIResults<string>.Failure(Messages.AuthFailure);
        }

        public async Task<APIResults<bool>> ResetPassword(UserModel request)
        {
            var username = DataHelpers.GetString(request.Username);
            var phoneNumber = DataHelpers.GetString(request.PhoneNumber);
            var mail = DataHelpers.GetString(request.Email);
            var password = DataHelpers.GetString(request.Password);
            var passwordHashed = PasswordHasher.HashPassword(password);

            var user = await _context.Users.AsNoTracking() // Tắt cơ chế "theo dõi thay đổi" (Change Tracking) của Entity Framework
                .FirstOrDefaultAsync(s => s.Username == username
               && s.PhoneNumber == phoneNumber && s.Email == mail);

            if (user == null)
                return APIResults<bool>.Failure(Messages.NotFoundUpdate);

            var validationResult = ValidatePassword(password);
            if (validationResult.Any())
            {
                var error = string.Join(", ", validationResult.Select(e =>
                    e.Description != null && e.Description.Length > 0
                    ? $"{e.Code}|{string.Join("|", e.Description)}" : e.Code));

                return APIResults<bool>.Failure(error);
            }

            user.PasswordHash = passwordHashed;

            var result = await _context.SaveChangesAsync();

            return result > 0
                ? APIResults<bool>.Success(true, Messages.ResetPasswordSuccess)
                : APIResults<bool>.Failure(Messages.ResetPasswordFailure);
        }

        public async Task<APIResults<bool>> SendOTP(MailModel mail)
        {
            var result = await MailHelpers.SendMail(mail);

            return result
                ? APIResults<bool>.Success(true, Messages.SendMailSuccess)
                : APIResults<bool>.Failure(Messages.SendMailFailure);
        }

        public List<IdentityError> ValidatePassword(string password)
        {
            var errors = new List<IdentityError>();

            if (password.Length < _options.Password.RequiredLength)
                errors.Add(new IdentityError { Code = Messages.RequiredLength, Description = _options.Password.RequiredLength.ToString() });

            if (_options.Password.RequireDigit && !password.Any(char.IsDigit))
                errors.Add(new IdentityError { Code = Messages.RequireDigit });

            if (_options.Password.RequireLowercase && !password.Any(char.IsLower))
                errors.Add(new IdentityError { Code = Messages.RequireLowercase });

            if (_options.Password.RequireUppercase && !password.Any(char.IsUpper))
                errors.Add(new IdentityError { Code = Messages.RequireUppercase });

            if (_options.Password.RequireNonAlphanumeric && password.All(char.IsLetterOrDigit))
                errors.Add(new IdentityError { Code = Messages.RequireNonAlphanumeric });

            if (password.Distinct().Count() < _options.Password.RequiredUniqueChars)
                errors.Add(new IdentityError { Code = Messages.RequiredUniqueChars, Description = _options.Password.RequiredUniqueChars.ToString() });

            return errors;
        }

        #endregion
    }
}
