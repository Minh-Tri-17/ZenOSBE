using ZenOS.MB;

namespace ZenOS.BLL.Interfaces
{
    public interface ICodeSequenceService
    {
        public Task<APIResults<bool>> Create(CodeSequenceModel request);
        public Task<APIResults<bool>> Update(CodeSequenceModel request);
    }
}
