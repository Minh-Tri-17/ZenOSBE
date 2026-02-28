using ZenOS.BLL.Interfaces;
using ZenOS.DAL.Models;
using ZenOS.MB;

namespace ZenOS.BLL.Services
{
    public class CatJobTitleService : BaseService<CatJobTitle, CatJobTitleModel>, ICatJobTitleService
    {
        #region Infrastructure

        public CatJobTitleService(ZenOsContext context, ICurrentUserService currentUser) : base(context, currentUser)
        {

        }

        #endregion

        #region Default Operations

        #endregion

        #region Custom Operations

        #endregion
    }
}
