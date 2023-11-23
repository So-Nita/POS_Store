using Microsoft.AspNetCore.Mvc;
using POSLibrary.DataModels.Category;
using POSLibrary.Interface.Category;
using POSLibrary.Interface.Product;

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
        [HttpGet("getAllCategory")]
        public IActionResult GetAll()
        {
            try
            {
                var categories = _service.GetAllCategory();
                return Ok(categories);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("getCategoryProduct")]   
        public IActionResult GetCategoryProduct()
        {
            try
            {
                var categories = _service.ReadAll();
                return Ok(categories);
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public IActionResult Post([FromBody] CategoryCreateReq req)
        {
            try
            {
                var categories = _service.Create(req);
                return Ok(categories);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
