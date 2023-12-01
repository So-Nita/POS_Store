using Microsoft.AspNetCore.Mvc;
using POSLibrary.Constant;
using POSLibrary.DataModels;
using POSLibrary.DataModels.Results;
using POSLibrary.DataModels.Supplier;
using POSLibrary.Interface;
using System.Runtime.InteropServices;

namespace POSApi.Controllers
{
    [ApiController]
    [Route("api/supplier")]
    public class SupplierController : Controller
    {
        private readonly ISupplierService _service;
        public SupplierController(ISupplierService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var data = _service.ReadAll();
                if(data.Status != (int)ResponseStatusType.Success)
                {
                    return BadRequest(data);
                }
                return Ok(data);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("getById")]
        public IActionResult GetById(ulong supplierId)
        {
            try
            {
                var data = _service.GetById(supplierId);
                
                return Ok(data);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public ActionResult<Results<string>> Create([FromBody] SupplierCreateReq req)
        {
            var data = new Results<string>();
            try
            {
                data = _service.Create(req);
                if(data.Status != (int)ResponseStatusType.Success)
                {
                    return BadRequest(data);
                }
                return Ok(data);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult<Results<string>> Update([FromBody] SupplierUpdateReq req)
        {
            try
            {
                var data = _service.Update(req);
                if(data.Status != (int)ResponseStatusType.Success)
                {
                    return BadRequest(data);    
                }
                return Ok(data);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        public ActionResult<Results<string>> Delete(ulong supplierId) 
        {
            try
            {
                var data = _service.Delete(supplierId);
                if (data.Status != (int)ResponseStatusType.Success)
                {
                    return NotFound(data);
                }
                return Ok(data);
            }
            catch(ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
