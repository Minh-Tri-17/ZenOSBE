using ZenOS.BLL.Interfaces;
using ZenOS.DAL.Models;
using ZenOS.MB;

namespace ZenOS.BLL.Services
{
    public class PurchaseOrderService : BaseService<PurchaseOrder, PurchaseOrderModel>, IPurchaseOrderService
    {
        #region Infrastructure

        public PurchaseOrderService(ZenOsContext context, ICurrentUserService currentUser) : base(context, currentUser)
        {

        }

        #endregion

        #region Default Operations

        #endregion

        #region Custom Operations

        #endregion
    }
}
