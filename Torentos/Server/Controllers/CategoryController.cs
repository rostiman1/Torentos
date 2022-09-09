using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Torentos.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> GetCategories()
        {
            var result = await _categoryService.GetCategories();
            return Ok(result);
        }
        //[HttpGet,Authorize(Roles="Admin")]
        [HttpGet("admin")]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> GetAllCategories()
        {
            var result = await _categoryService.GetAllCategories();
            return Ok(result);
        }
        [HttpDelete("admin/{id}")]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> DeleteCategory(int id)
        {
            var result = await _categoryService.DeleteCategory(id);
            return Ok(result);
        }
        [HttpPost("admin")]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> AddCategory(Category category)
        {
            var result = await _categoryService.AddCategory(category);
            return Ok(result);
        }
        [HttpPut("admin")]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> UpdateCategory(Category category)
        {
            var result = await _categoryService.UpdateCategory(category);
            return Ok(result);
        }
    }
}
