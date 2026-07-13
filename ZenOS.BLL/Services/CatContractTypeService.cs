using Microsoft.Extensions.Localization;
using ZenOS.BLL.Interfaces;
using ZenOS.DAL.Models;
using ZenOS.MB;

namespace ZenOS.BLL.Services
{
    public class CatContractTypeService : BaseService<CatContractType, CatContractTypeModel>, ICatContractTypeService
    {
        #region Infrastructure

        public CatContractTypeService(ZenOsContext context, ICurrentUserService currentUser, IStringLocalizer localizer) : base(context, currentUser, localizer)
        {

        }

        #endregion

        #region Default Operations

        #endregion

        #region Custom Operations

        #endregion
    }
}
