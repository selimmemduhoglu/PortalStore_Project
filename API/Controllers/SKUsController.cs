using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SKUsController : ControllerBase
    {
        ISKUService _skuService;

        public SKUsController(ISKUService skuService)
        {
            _skuService = skuService;
        }

        [HttpPost("add")]
        public IActionResult Add(SKU sku)
        {
            var result = _skuService.Add(sku);
            if (!result.Success) return BadRequest(result);

            return Ok(result);
        }

        [HttpPost("update")]
        public IActionResult Update(SKU sku)
        {
            var result = _skuService.Update(sku);
            if (!result.Success) return BadRequest(result);

            return Ok(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(SKU sku)
        {
            var result = _skuService.Delete(sku);
            if (!result.Success) return BadRequest(result);

            return Ok(result);
        }

        [HttpGet("getById")]
        public IActionResult GetById(int id)
        {
            var result = _skuService.GetById(id);
            if (!result.Success) return BadRequest(result);

            return Ok(result);
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var result = _skuService.GetAll();
            if (!result.Success) return BadRequest(result);

            return Ok(result);
        }
    }
}

