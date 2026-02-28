using ZenOS.BLL.Interfaces;
using ZenOS.DAL.Models;
using ZenOS.MB;

namespace ZenOS.BLL.Services
{
    public class SalaryStructureService : BaseService<SalaryStructure, SalaryStructureModel>, ISalaryStructureService
    {
        #region Infrastructure

        public SalaryStructureService(ZenOsContext context, ICurrentUserService currentUser) : base(context, currentUser)
        {

        }

        #endregion

        #region Default Operations

        #endregion

        #region Custom Operations

        #endregion
    }
}
