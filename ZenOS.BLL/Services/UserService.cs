using ZenOS.BLL.Interfaces;
using ZenOS.DAL.Models;
using ZenOS.MB;
using ZenOS.Util;

namespace ZenOS.BLL.Services
{
    public class UserService : BaseService<User, UserModel>, IUserService
    {
        #region Infrastructure

        public UserService(ZenOsContext context, ICurrentUserService currentUser) : base(context, currentUser)
        {

        }

        #endregion

        #region Default Operations

        protected override Task BeforeSaveAsync(UserModel request, User entity, bool isNew)
        {
            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                request.PasswordHash = PasswordHasher.HashPassword(request.Password);
            }
            else if (!isNew)
            {
                request.PasswordHash = entity.PasswordHash;
            }

            return Task.CompletedTask; // Hoàn thành phương thức trả về Task khi không cần dùng await.
        }

        protected override async Task AfterSaveAsync(UserModel request, User entity)
        {
            var existingRoles = _context.UserRoles.Where(x => x.UserId == entity.Id);
            _context.UserRoles.RemoveRange(existingRoles);

            if (request.RoleIds != null && request.RoleIds.Any())
            {
                var userRoles = request.RoleIds.Select(roleId => new UserRole
                {
                    UserId = entity.Id,
                    RoleId = DataHelpers.GetGuid(roleId)
                });

                await _context.UserRoles.AddRangeAsync(userRoles);
            }
        }

        #endregion

        #region Custom Operations

        #endregion
    }
}
