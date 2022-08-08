using RestaurantAPI.Models;
using RestaurantAPI.Utils;

namespace RestaurantAPI.Services
{
    public class MenuService : IMenuService
    {        

        public async Task<MenuConfiguration> GetAllMenusAsync()
        {
            MenuConfiguration menuConfiguration = Data.GetSampleData();
            return menuConfiguration;
        }

        public async Task<List<MenuItem>> GetItemByCategory(string categoryId, CancellationToken cancellationToken = default)
        {
            MenuConfiguration menu = Data.GetSampleData();

            var results = menu.Items.Where(i => i.SectionId.Equals(categoryId)).ToList();

            return results;
        }
        public async Task<MenuConfiguration> GetItemByDish(string dishId, CancellationToken cancellationToken = default)
        {
            MenuConfiguration menu = Data.GetSampleData();

            var results = menu.Items.Where(i => i.SectionId.Equals(dishId));
            //TODO: Build the menu configuration based on dishid - this pulls the items and price

            return menu;
        }
    }
}
