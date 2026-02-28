using ZenOS.BLL.Interfaces;
using ZenOS.DAL.Models;
using ZenOS.MB;

namespace ZenOS.BLL.Services
{
    public class ApprovalStepAssignmentService : BaseService<ApprovalStepAssignment, ApprovalStepAssignmentModel>, IApprovalStepAssignmentService
    {
        #region Infrastructure

        public ApprovalStepAssignmentService(ZenOsContext context, ICurrentUserService currentUser) : base(context, currentUser)
        {

        }

        #endregion

        #region Default Operations

        #endregion

        #region Custom Operations

        #endregion
    }
}
