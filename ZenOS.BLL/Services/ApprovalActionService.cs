using ZenOS.BLL.Interfaces;
using ZenOS.DAL.Models;
using ZenOS.MB;

namespace ZenOS.BLL.Services
{
    public class ApprovalActionService : BaseService<ApprovalAction, ApprovalActionModel>, IApprovalActionService
    {
        #region Infrastructure

        public ApprovalActionService(ZenOsContext context, ICurrentUserService currentUser) : base(context, currentUser)
        {

        }

        #endregion

        #region Default Operations

        #endregion

        #region Custom Operations

        #endregion
    }
}
