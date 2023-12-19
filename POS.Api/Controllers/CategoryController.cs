using Microsoft.AspNetCore.Mvc;
using POSLibrary.Constant;
using POSLibrary.DataModels.Category;
using POSLibrary.Interface.Category;
using POSLibrary.Interface.Product;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace POSApi.Controllers
{
    [ApiController]
    [Route("api/category")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _service;
        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var data = _service.GetAllCategory();
                if (data.Status != (int)ResponseStatusType.Success)
                {
                    return BadRequest(data);
                }
                return Ok(data);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("getCategoryProduct")]   
        public IActionResult GetCategoryProduct()
        {
            try
            {
                var data = _service.ReadAll();
                if (data.Status != (int)ResponseStatusType.Success)
                {
                    return BadRequest(data);
                }
                return Ok(data);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] CategoryCreateReq req)
        {
            try
            {
                var data = _service.Create(req);
                if (data.Status != (int)ResponseStatusType.Success)
                {
                    return BadRequest(data);
                }
                return Ok(data);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] CategoryUpdateReq req)
        {
            try
            {
                var data = _service.Update(req);
                if (data.Status != (int)ResponseStatusType.Success)
                {
                    return BadRequest(data);
                }
                return Ok(data);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        public IActionResult Delete(ulong req)
        {
            try
            {
                var data = _service.Delete(req);
                if (data.Status != (int)ResponseStatusType.Success)
                {
                    return BadRequest(data);
                }
                return Ok(data);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
