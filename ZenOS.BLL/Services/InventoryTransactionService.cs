using ZenOS.BLL.Interfaces;
using ZenOS.DAL.Models;
using ZenOS.MB;

namespace ZenOS.BLL.Services
{
    public class InventoryTransactionService : BaseService<InventoryTransaction, InventoryTransactionModel>, IInventoryTransactionService
    {
        #region Infrastructure

        public InventoryTransactionService(ZenOsContext context, ICurrentUserService currentUser) : base(context, currentUser)
        {

        }

        #endregion

        #region Default Operations

        #endregion

        #region Custom Operations

        #endregion
    }
}
