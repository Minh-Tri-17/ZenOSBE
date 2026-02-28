using ZenOS.BLL.Interfaces;
using ZenOS.DAL.Models;
using ZenOS.MB;

namespace ZenOS.BLL.Services
{
    public class ComboItemService : BaseService<ComboItem, ComboItemModel>, IComboItemService
    {
        #region Infrastructure

        public ComboItemService(ZenOsContext context, ICurrentUserService currentUser) : base(context, currentUser)
        {

        }

        #endregion

        #region Default Operations

        #endregion

        #region Custom Operations

        #endregion
    }
}
