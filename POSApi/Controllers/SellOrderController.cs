using Microsoft.AspNetCore.Mvc;
using POSLibrary.Constant;
using POSLibrary.DataModels;
using POSLibrary.DataModels.Results;
using POSLibrary.DataModels.SellOrder;
using POSLibrary.Interface.SellOrder;

namespace POSApi.Controllers
{
    [ApiController]
    [Route("api/sellOrder")]
    public class SellOrderController : Controller
    {
        private readonly ISellOrderService _service;
        public SellOrderController(ISellOrderService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<Results<IEnumerable<SellOrderResponse>>> GetAll()
        {
            try
            {
                var data = _service.ReadAll();
                return Ok(data);
            }catch 
            {
                return BadRequest(Results<IEnumerable<SellOrderResponse>>.Success());
            }
        }

        [HttpPost]
        public ActionResult<Results<SellOrderCreateReq>> Create(SellOrderCreateReq req)
        {
            try
            {
                var data = _service.Create(req);
                if(data.Status != (int)ResponseStatusType.Success)
                {
                    return BadRequest(data);
                }
                return Ok(data);
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPut]
        public  ActionResult<Results<string>> Delete (Key<ulong> key)
        {
            try
            {
                var data = _service.Delete(key.Id);
                if(data.Status != (int)ResponseStatusType.Success)
                {
                    return BadRequest(data);
                }
                return Ok(data);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
