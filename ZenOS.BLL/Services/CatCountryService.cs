using ZenOS.BLL.Interfaces;
using ZenOS.DAL.Models;
using ZenOS.MB;

namespace ZenOS.BLL.Services
{
    public class CatCountryService : BaseService<CatCountry, CatCountryModel>, ICatCountryService
    {
        #region Infrastructure

        public CatCountryService(ZenOsContext context, ICurrentUserService currentUser) : base(context, currentUser)
        {

        }

        #endregion

        #region Default Operations

        #endregion

        #region Custom Operations

        #endregion
    }
}
