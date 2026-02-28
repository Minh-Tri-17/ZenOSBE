using ZenOS.BLL.Interfaces;
using ZenOS.DAL.Models;
using ZenOS.MB;

namespace ZenOS.BLL.Services
{
    public class LeaveRequestService : BaseService<LeaveRequest, LeaveRequestModel>, ILeaveRequestService
    {
        #region Infrastructure

        public LeaveRequestService(ZenOsContext context, ICurrentUserService currentUser) : base(context, currentUser)
        {

        }

        #endregion

        #region Default Operations

        #endregion

        #region Custom Operations

        #endregion
    }
}
