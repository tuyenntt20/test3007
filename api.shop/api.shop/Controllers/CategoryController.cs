using api.shop.Entities;
using api.shop.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api.shop.Controllers
{
    [ApiController]
    [Route("api/categories")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await _categoryService.GetCategoriesAsync();
        }
    }
}

