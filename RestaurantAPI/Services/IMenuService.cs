using RestaurantAPI.Models;

namespace RestaurantAPI.Services
{
    public interface IMenuService
    {
        Task<MenuConfiguration> GetAllMenusAsync();
        Task<List<MenuItem>> GetItemByCategory(string categoryId, CancellationToken cancellationToken = default);
        Task<MenuConfiguration> GetItemByDish(string dishId, CancellationToken cancellationToken = default);
    }
}
