using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using ZenOS.BLL.Interfaces;
using ZenOS.Util;

namespace ZenOS.BLL.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor; // Sau khi Authorize, HttpContextAccessor sẽ có thông tin người dùng
        }

        public Guid UserId => DataHelpers.GetGuid(_httpContextAccessor.HttpContext?.User?.FindFirst("UserID")?.Value);

        public Guid OwnerId => DataHelpers.GetGuid(_httpContextAccessor.HttpContext?.User?.FindFirst("OwnerID")?.Value);

        public string UserName => _httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.Name)?.Value ?? string.Empty;

        public string FullName => _httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.GivenName)?.Value ?? string.Empty;

        public string RoleId => _httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.Role)?.Value ?? string.Empty;
    }
}
