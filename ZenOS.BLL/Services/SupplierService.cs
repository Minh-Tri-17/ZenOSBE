using Microsoft.Extensions.Localization;
using ZenOS.BLL.Interfaces;
using ZenOS.DAL.Models;
using ZenOS.MB;

namespace ZenOS.BLL.Services
{
    public class SupplierService : BaseService<Supplier, SupplierModel>, ISupplierService
    {
        #region Infrastructure

        public SupplierService(ZenOsContext context, ICurrentUserService currentUser, IStringLocalizer localizer) : base(context, currentUser, localizer)
        {

        }

        #endregion

        #region Default Operations

        #endregion

        #region Custom Operations

        #endregion
    }
}
