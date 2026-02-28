using ZenOS.BLL.Interfaces;
using ZenOS.DAL.Models;
using ZenOS.MB;

namespace ZenOS.BLL.Services
{
    public class CatLeaveTypeService : BaseService<CatLeaveType, CatLeaveTypeModel>, ICatLeaveTypeService
    {
        #region Infrastructure

        public CatLeaveTypeService(ZenOsContext context, ICurrentUserService currentUser) : base(context, currentUser)
        {

        }

        #endregion

        #region Default Operations

        #endregion

        #region Custom Operations

        #endregion
    }
}
