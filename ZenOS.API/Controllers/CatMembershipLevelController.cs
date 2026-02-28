using Microsoft.AspNetCore.Mvc;
using ZenOS.BLL.Interfaces;
using ZenOS.DAL.Models;
using ZenOS.MB;

namespace ZenOS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatMembershipLevelController : BaseController<ICatMembershipLevelService, CatMembershipLevel, CatMembershipLevelModel>
    {
        #region Infrastructure

        public CatMembershipLevelController(ICatMembershipLevelService appointmentService) : base(appointmentService)
        {

        }

        #endregion

        #region Default Operations

        #endregion

        #region Custom Operations

        #endregion
    }
}
