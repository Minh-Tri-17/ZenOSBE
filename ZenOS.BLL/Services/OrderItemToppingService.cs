using ZenOS.BLL.Interfaces;
using ZenOS.DAL.Models;
using ZenOS.MB;

namespace ZenOS.BLL.Services
{
    public class OrderItemToppingService : BaseService<OrderItemTopping, OrderItemToppingModel>, IOrderItemToppingService
    {
        #region Infrastructure

        public OrderItemToppingService(ZenOsContext context, ICurrentUserService currentUser) : base(context, currentUser)
        {

        }

        #endregion

        #region Default Operations

        #endregion

        #region Custom Operations

        #endregion
    }
}
