using ZenOS.BLL.Interfaces;
using ZenOS.DAL.Models;
using ZenOS.MB;

namespace ZenOS.BLL.Services
{
    public class CodeSequenceService : ICodeSequenceService
    {
        #region Infrastructure

        private readonly ZenOsContext _context; // Dùng để truy cập vào DbContext
        private readonly ICurrentUserService _currentUser; // Dùng để lấy thông tin người dùng hiện tại

        public CodeSequenceService(ZenOsContext context, ICurrentUserService currentUser)
        {
            _context = context;
            _currentUser = currentUser;
        }

        #endregion

        #region Default Operations

        public Task<APIResults<bool>> CreateOrEdit(CodeSequenceModel request)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Custom Operations

        #endregion
    }
}
