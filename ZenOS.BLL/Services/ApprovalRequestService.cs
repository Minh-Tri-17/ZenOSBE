using ZenOS.BLL.Interfaces;
using ZenOS.DAL.Models;
using ZenOS.MB;

namespace ZenOS.BLL.Services
{
    public class ApprovalRequestService : BaseService<ApprovalRequest, ApprovalRequestModel>, IApprovalRequestService
    {
        #region Infrastructure

        public ApprovalRequestService(ZenOsContext context, ICurrentUserService currentUser) : base(context, currentUser)
        {

        }

        #endregion

        #region Default Operations

        #endregion

        #region Custom Operations

        #endregion
    }
}
