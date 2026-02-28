using ZenOS.BLL.Interfaces;
using ZenOS.DAL.Models;
using ZenOS.MB;

namespace ZenOS.BLL.Services
{
    public class CatMembershipLevelService : BaseService<CatMembershipLevel, CatMembershipLevelModel>, ICatMembershipLevelService
    {
        #region Infrastructure

        public CatMembershipLevelService(ZenOsContext context, ICurrentUserService currentUser) : base(context, currentUser)
        {

        }

        #endregion

        #region Default Operations

        #endregion

        #region Custom Operations

        #endregion
    }
}
