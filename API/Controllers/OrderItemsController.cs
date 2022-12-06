using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemsController : ControllerBase
    {
        IOrderItemService _orderItemService;

        public OrderItemsController(IOrderItemService orderItemService)
        {
            _orderItemService = orderItemService;
        }

        [HttpPost("add")]
        public IActionResult Add(OrderItem orderItem)
        {
            var result = _orderItemService.Add(orderItem);
            if (!result.Success) return BadRequest(result);

            return Ok(result);
        }

        [HttpPost("update")]
        public IActionResult Update(OrderItem orderItem)
        {
            var result = _orderItemService.Update(orderItem);
            if (!result.Success) return BadRequest(result);

            return Ok(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(OrderItem orderItem)
        {
            var result = _orderItemService.Delete(orderItem);
            if (!result.Success) return BadRequest(result);

            return Ok(result);
        }

        [HttpGet("getById")]
        public IActionResult GetById(int id)
        {
            var result = _orderItemService.GetById(id);
            if (!result.Success) return BadRequest(result);

            return Ok(result);
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var result = _orderItemService.GetAll();
            if (!result.Success) return BadRequest(result);

            return Ok(result);
        }
    }
}

