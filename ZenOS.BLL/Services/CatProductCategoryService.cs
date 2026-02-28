using ZenOS.BLL.Interfaces;
using ZenOS.DAL.Models;
using ZenOS.MB;

namespace ZenOS.BLL.Services
{
    public class CatProductCategoryService : BaseService<CatProductCategory, CatProductCategoryModel>, ICatProductCategoryService
    {
        #region Infrastructure

        public CatProductCategoryService(ZenOsContext context, ICurrentUserService currentUser) : base(context, currentUser)
        {

        }

        #endregion

        #region Default Operations

        #endregion

        #region Custom Operations

        #endregion
    }
}
