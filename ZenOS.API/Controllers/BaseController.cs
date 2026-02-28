using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ZenOS.BLL.Interfaces;
using ZenOS.MB;
using ZenOS.Util;

namespace ZenOS.API.Controllers
{
    // abstract: Ngăn chặn việc khởi tạo trực tiếp
    // virtual: Là các hàm có logic mặc định nhưng cho phép lớp con ghi đè
    [Route("api/[controller]")]
    [ApiController]
    [Authorize] // Đặt ở đây để toàn bộ API đều cần xác thực
    public abstract class BaseController<TService, TEntity, TModel> : ControllerBase
        where TService : IBaseService<TEntity, TModel> // Đảm bảo Service truyền vào có đủ các hàm chuẩn (Create, Update, Delete) để gọi.
        where TEntity : class // Giới hạn kiểu dữ liệu phải là đối tượng để tương thích với EF Core và xử lý Null
        where TModel : class
    {
        protected readonly TService _service;

        protected BaseController(TService service)
        {
            _service = service;
        }

        [HttpPost(nameof(CreateOrEdit))]
        public virtual async Task<ActionResult> CreateOrEdit(TModel model)
        {
            if (model == null)
                return BadRequest();

            var result = await _service.CreateOrEdit(model);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpDelete(nameof(Delete))]
        public virtual async Task<ActionResult> Delete(string ids)
        {
            var result = await _service.Delete(ids);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpGet($"{nameof(GetOne)}/{{id}}")]
        public virtual async Task<ActionResult> GetOne(Guid id)
        {
            var result = await _service.GetOne(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpPost($"{nameof(GetPaging)}/Filter")]
        public virtual async Task<ActionResult> GetPaging(FilterModel filter)
        {
            var result = await _service.GetPaging(filter);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpPost(nameof(Import))]
        public virtual async Task<ActionResult> Import()
        {
            var excelFile = Request.Form.Files[Constants.ExcelFiles];
            if (excelFile == null)
                return BadRequest(Constants.FileNotFound);

            var result = await _service.Import(excelFile);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
