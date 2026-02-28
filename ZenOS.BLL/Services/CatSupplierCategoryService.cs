using ZenOS.BLL.Interfaces;
using ZenOS.DAL.Models;
using ZenOS.MB;

namespace ZenOS.BLL.Services
{
    public class CatSupplierCategoryService : BaseService<CatSupplierCategory, CatSupplierCategoryModel>, ICatSupplierCategoryService
    {
        #region Infrastructure

        public CatSupplierCategoryService(ZenOsContext context, ICurrentUserService currentUser) : base(context, currentUser)
        {

        }

        #endregion

        #region Default Operations

        #endregion

        #region Custom Operations

        #endregion
    }
}
