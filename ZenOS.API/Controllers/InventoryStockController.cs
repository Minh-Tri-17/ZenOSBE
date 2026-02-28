using Microsoft.AspNetCore.Mvc;
using ZenOS.BLL.Interfaces;
using ZenOS.DAL.Models;
using ZenOS.MB;

namespace ZenOS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryStockController : BaseController<IInventoryStockService, InventoryStock, InventoryStockModel>
    {
        #region Infrastructure

        public InventoryStockController(IInventoryStockService appointmentService) : base(appointmentService)
        {

        }

        #endregion

        #region Default Operations

        #endregion

        #region Custom Operations

        #endregion
    }
}
