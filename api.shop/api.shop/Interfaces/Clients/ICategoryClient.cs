using api.shop.Entities;

namespace api.shop.Interfaces.Clients
{
    public interface ICategoryClient
    {
        Task<IEnumerable<Category>> GetCategoriesAsync();
    }
}

