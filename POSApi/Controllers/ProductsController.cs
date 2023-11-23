using Microsoft.AspNetCore.Mvc;
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
                var data = _service.Delete(id.ToString()!);
                var result = Results<IEnumerable<string>>.Success(new List<string>() { "Delete Successfully"});
                return Ok(result);
            }
            catch
            {
                return BadRequest(Results<IEnumerable<string>>.Fail(new List<string>() { "Fail to delete."}));
            }
        }
        [HttpGet("getById")]
        public ActionResult<Results<ProductResponse>> GetById(ulong id)
        {
            try
            {
                if(id == null) {
                    return BadRequest(Results<IEnumerable<string>>.Fail(new List<string>() { "Id is required." }));
                }
                var data = _service.GetById(id);
                return Ok(data);
            }
            catch
            {
                return BadRequest(Results<IEnumerable<string>>.Fail(new List<string>() { "Fail to delete." }));
            }
        }
    }
}
