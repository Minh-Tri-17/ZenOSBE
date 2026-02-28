using ZenOS.MB;

namespace ZenOS.BLL.Interfaces
{
    public interface ICodeSequenceService
    {
        public Task<APIResults<bool>> CreateOrEdit(CodeSequenceModel request);
    }
}
