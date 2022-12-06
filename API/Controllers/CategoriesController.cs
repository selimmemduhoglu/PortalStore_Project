using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost("add")]
        public IActionResult Add(Category category)
        {
            var result = _categoryService.Add(category);
            if (!result.Success) return BadRequest(result);

            return Ok(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Category category)
        {
            var result = _categoryService.Update(category);
            if (!result.Success) return BadRequest(result);

            return Ok(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Category category)
        {
            var result = _categoryService.Delete(category);
            if (!result.Success) return BadRequest(result);

            return Ok(result);
        }

        [HttpGet("getById")]
        public IActionResult GetById(int id)
        {
            var result = _categoryService.GetById(id);
            if (!result.Success) return BadRequest(result);

            return Ok(result);
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var result = _categoryService.GetAll();
            if (!result.Success) return BadRequest(result);

            return Ok(result);
        }
    }
}
