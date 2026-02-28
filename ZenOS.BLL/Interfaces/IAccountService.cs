using Microsoft.AspNetCore.Identity;
using ZenOS.MB;

namespace ZenOS.BLL.Interfaces
{
    public interface IAccountService
    {
        public Task<APIResults<string>> Auth(UserModel request);
        public Task<APIResults<bool>> SendOTP(MailModel mail);
        public Task<APIResults<bool>> ResetPassword(UserModel request);
        public List<IdentityError> ValidatePassword(string password);
    }
}
