using Microsoft.AspNetCore.Mvc;
using POSLibrary.Constant;
using POSLibrary.DataModels;
using POSLibrary.DataModels.Product;
using POSLibrary.DataModels.Results;
using POSLibrary.Interface.Product;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace POSApi.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductsController : Controller
    {
        private readonly IProductService _service;
        public ProductsController(IProductService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<Results<ProductResponse>> GetAll()
        {
            try
            {
                var data = _service.ReadAll();
                return Ok(data);
            }
            catch
            {
                return Results<ProductResponse>.Fail();
            }
        }
        [HttpGet("getProductByCategoryId")]
        public ActionResult<Results<ProductResponse>> GetProductByCategoryId(int categoryId)
        {
            try
            {
                var data = _service.ReadByCategoryId(categoryId);
                return Ok(data);
            }
            catch { return Results<ProductResponse>.Fail(); }
        }
        [HttpPost]
        public ActionResult<Results<string>> Create([FromBody] ProductCreateReq req)
        {
            try
            {
                var data = _service.Create(req);
                return Ok(data);
            }
            catch
            {
                return Results<string>.Fail();
            }
        }
        
        [HttpPut]
        public ActionResult<Results<string>> Update([FromBody] ProductUpdateReq req)
        {
            try
            {
                var data = _service.Update(req);
                return Ok(data);
            }
            catch
            {
                return Results<string>.Fail();
            }
        }
        [HttpDelete]
        public ActionResult<Results<string>> Delete([FromBody] ulong id)
        {
            try
            {
                var data = _service.Delete(id);
                if (data.Status != (int)ResponseStatusType.Success)
                {
                    return BadRequest(data);
                }
                return Ok(data);
            }
            catch(Exception ex)
            {
                return BadRequest(Results<IEnumerable<string>>.Fail(new List<string>() { ex.Message}));
            }
        }
        [HttpGet("getById")]
        public ActionResult<Results<ProductResponse>> GetById(ulong id)
        {
            try
            {
                var data = _service.GetById(id);
                if(data.Status != (int)ResponseStatusType.Success)
                {
                    return BadRequest(data);
                }
                return Ok(data);
            }
            catch(Exception ex)  
            {
                return BadRequest(Results<IEnumerable<string>>.Fail(new List<string>() {ex.Message }));
            }
        }
    }
}
