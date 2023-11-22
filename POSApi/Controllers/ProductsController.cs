using Microsoft.AspNetCore.Mvc;
using POSLibrary.DataModels.Product;
using POSLibrary.DataModels.Results;
using POSLibrary.Interface.Product;

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
        public ActionResult<CustomResponse<ProductResponse>> GetAll()
        {
            try
            {
                var data = _service.ReadAll();
                var customResponse = new CustomResponse<ProductResponse>
                {
                    Status = 200,
                    Total = data.Count,
                    Result = data
                };
                return Ok(customResponse);
            }
            catch
            {
                return StatusCode(500, new CustomResponse<ProductResponse> { Status = 500 });
            }
        }


    }
}
