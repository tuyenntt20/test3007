using api.shop.Entities;
using api.shop.Interfaces;
using api.shop.Interfaces.Clients;

namespace api.shop.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryClient _categoryClient;

        public CategoryService(ICategoryClient categoryClient)
        {
            _categoryClient = categoryClient;
        }

        public Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return _categoryClient.GetCategoriesAsync();
        }
    }
}

