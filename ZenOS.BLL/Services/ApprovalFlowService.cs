using ZenOS.BLL.Interfaces;
using ZenOS.DAL.Models;
using ZenOS.MB;

namespace ZenOS.BLL.Services
{
    public class ApprovalFlowService : BaseService<ApprovalFlow, ApprovalFlowModel>, IApprovalFlowService
    {
        #region Infrastructure

        public ApprovalFlowService(ZenOsContext context, ICurrentUserService currentUser) : base(context, currentUser)
        {

        }

        #endregion

        #region Default Operations

        #endregion

        #region Custom Operations

        #endregion
    }
}
