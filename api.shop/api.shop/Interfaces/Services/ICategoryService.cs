using api.shop.Entities;

namespace api.shop.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetCategoriesAsync();
    }
}

