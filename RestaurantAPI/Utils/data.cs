using RestaurantAPI.Models;

namespace RestaurantAPI.Utils
{
    public static class Data
    {
        public static MenuConfiguration GetSampleData()
        {
            MenuConfiguration menuConfiguration = new MenuConfiguration()
            {
                Menu = new List<Menu>
                {
                    new Menu { Id = "M1", Name = "Brunch" },
                    new Menu { Id = "M2", Name = "Breakfast" },
                    new Menu { Id = "M3", Name = "Lunch" }
                },
                Section = new List<Section> //define the type
                {
                    new Section { Id = "cat1", Name = "Egg Dishes", MenuId = "M1", Type = "Category" },
                    new Section { Id = "dis1", Name = "Salad", MenuId = "M2", Type = "Dish" },
                    new Section { Id = "opt1", Name = "Chicken", MenuId = "M3", Type = "Option" }
                },
                Items = new List<MenuItem> //dish and option has prices
                {
                    new MenuItem { Id = "i1", Name = "Scrumlbed Egg", Description = "scrumbled eggs", ImageUrl = "https://images.com/image1.jpeg", SectionId = "cat1" },
                    new MenuItem { Id = "i2", Name = "Ceaser Salad", Description = "ceaser salad", ImageUrl = "https://images.com/image2.jpeg", SectionId = "dis1" },
                    new MenuItem { Id = "i3", Name = "Chicken Wings", Description = "chicken wings", ImageUrl = "https://images.com/image3.jpeg", SectionId = "opt1" }
                },
                Prices = new List<Price>
                {
                    new Price { Id = "p1", ItemId = "i2", Rate = 54.50d },
                    new Price { Id = "p2", ItemId = "i3", Rate = 135.00d }
                },
                Offers = new List<Offer>
                {
                    new Offer { Id = "O1", ItemId = "i1", Description = "offer1" },
                    new Offer { Id = "O2", ItemId = "i2", Description = "offer2" }
                },
                Rating = new List<Rating>
                {
                    new Rating{ Id="R1", ItemId="i1", Comments="sample comments"}
                }

            };
            return menuConfiguration;
        }
        
    }
}
