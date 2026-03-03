using Microsoft.AspNetCore.Mvc;
using ZenOS.BLL.Interfaces;
using ZenOS.DAL.Models;
using ZenOS.MB;

namespace ZenOS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        #region Infrastructure

        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        #endregion

        #region Default Operations

        #endregion

        #region Custom Operations

        [HttpPost(nameof(Authentication))]
        public async Task<ActionResult<User>> Authentication([FromBody] UserModel user)
        {
            if (user == null)
                return BadRequest();

            var result = await _accountService.Auth(user);

            if (!result.IsSuccess)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPost(nameof(SendOTP))]
        public async Task<ActionResult<APIResults<bool>>> SendOTP([FromBody] MailModel mail)
        {
            if (mail == null)
                return BadRequest();

            var result = await _accountService.SendOTP(mail);

            if (!result.IsSuccess)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPost(nameof(ResetPassword))]
        public async Task<ActionResult<APIResults<bool>>> ResetPassword([FromBody] UserModel user)
        {
            if (user == null)
                return BadRequest();

            var result = await _accountService.ResetPassword(user);

            if (!result.IsSuccess)
                return BadRequest(result);

            return Ok(result);
        }

        #endregion
    }
}
