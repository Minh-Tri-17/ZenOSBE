using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
        public async Task<ActionResult<User>> Authentication()
        {
            var user = new UserModel();

            if (Request.HasFormContentType)
            {
                var json = Request.Form["Json"];
                if (!string.IsNullOrEmpty(json))
                    user = JsonConvert.DeserializeObject<UserModel>(json!);
            }
            else
            {
                using var reader = new StreamReader(Request.Body);
                var body = await reader.ReadToEndAsync();
                if (!string.IsNullOrEmpty(body))
                    user = JsonConvert.DeserializeObject<UserModel>(body);
            }

            if (user == null)
                return BadRequest();

            var result = await _accountService.Auth(user);
            if (!result.IsSuccess)
                return BadRequest(result);

            return Ok(result);
        }


        [HttpPost(nameof(SendOTP))]
        public async Task<ActionResult<APIResults<bool>>> SendOTP()
        {
            var mail = new MailModel();

            if (Request.HasFormContentType)
            {
                var json = Request.Form["Json"];
                if (!string.IsNullOrEmpty(json))
                    mail = JsonConvert.DeserializeObject<MailModel>(json!);
            }
            else
            {
                using var reader = new StreamReader(Request.Body);
                var body = await reader.ReadToEndAsync();
                if (!string.IsNullOrEmpty(body))
                    mail = JsonConvert.DeserializeObject<MailModel>(body);
            }

            if (mail == null)
                return BadRequest();

            var result = await _accountService.SendOTP(mail);
            if (!result.IsSuccess)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPost(nameof(ResetPassword))]
        public async Task<ActionResult<APIResults<bool>>> ResetPassword()
        {
            var user = new UserModel();

            if (Request.HasFormContentType)
            {
                var json = Request.Form["Json"];
                if (!string.IsNullOrEmpty(json))
                    user = JsonConvert.DeserializeObject<UserModel>(json!);
            }
            else
            {
                using var reader = new StreamReader(Request.Body);
                var body = await reader.ReadToEndAsync();
                if (!string.IsNullOrEmpty(body))
                    user = JsonConvert.DeserializeObject<UserModel>(body);
            }

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
