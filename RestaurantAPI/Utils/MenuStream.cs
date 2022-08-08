using RestaurantAPI.Models;

namespace RestaurantAPI.Utils
{
    //public class MenuParsing
    //{

    //    public MenuConfiguration GetAllMenus()
    //    {

    //        /*
    //         * item id
    //         * type = dish,category or option
    //         * item name
    //         * price = dish and option but not for category
    //         * Any other line: A list of item IDs that are linked to the current item. OPTIONs do not have any linked items.(???)
    //         */
    //        MenuConfiguration menuConfiguration = new MenuConfiguration()
    //        {
    //            Menus = new List<Menu>
    //            {
    //                new Menu {
    //                    Id = "1",
    //                    Title = "Brunch",
    //                    Category_ids = new List<string> { "1" },
    //                    Service_availablity = new List<ServiceAvailability>
    //                    {
    //                        new ServiceAvailability
    //                        {
    //                            Day_of_week="Monday",
    //                            Time_periods=new List<TimePeriod>
    //                            { new TimePeriod
    //                            {
    //                                Start_time="",End_time=""
    //                            }
    //                            }
    //                        }
    //                    }
    //                }                    
    //            }, 
    //            Categories = new List<Category> //type
    //            {
    //                 new Category
    //                 {
    //                    Id="1",
    //                     Title="Egg dishes",
    //                     Entities=new List<MenuEntity>
    //                     {
    //                         new MenuEntity
    //                         {
    //                             Id="1",
    //                             Type="Dish" // it can be category or option
    //                         }
    //                     }
    //                 }
    //            },
    //            Items =new List<Item> //items corresponding to the category
    //            {
    //                 new Item {Id = "1", Title ="scrambled eggs", Image_url="", Price=39.5d },
    //                 new Item {Id = "2", Title ="eggs benediet", Image_url="", Price=39.5d }                    
    //            },               
    //            Options=new List<Options>
    //            {

    //            }                
    //        };

    //        return menuConfiguration;
    //    }

    //    public MenuConfiguration GetMenuItems()
    //    {          
    //        /*
    //        * item id
    //        * type = dish,category or option
    //        * item name
    //        * price = dish and option but not for category
    //        * Any other line: A list of item IDs that are linked to the current item. OPTIONs do not have any linked items.(???)
    //        */
    //        MenuConfiguration menuConfiguration = new MenuConfiguration()
    //        {
    //            Menus = new List<Menu>
    //            {
    //                new Menu {
    //                    Id = "1",
    //                    Title = "Brunch",
    //                    Category_ids = new List<string> { "1" },
    //                    Service_availablity = new List<ServiceAvailability>
    //                    {
    //                        new ServiceAvailability
    //                        {
    //                            Day_of_week="DAILY",
    //                            Time_periods=new List<TimePeriod>
    //                            { new TimePeriod
    //                            {
    //                                Start_time="6 AM",End_time="1 PM"
    //                            }
    //                            }
    //                        }
    //                    }
    //                },
    //                new Menu {
    //                    Id = "1",
    //                    Title = "Breakfast",
    //                    Category_ids = new List<string> { "2" },
    //                    Service_availablity = new List<ServiceAvailability>
    //                    {
    //                        new ServiceAvailability
    //                        {
    //                            Day_of_week="DAILY",
    //                            Time_periods=new List<TimePeriod>
    //                            { new TimePeriod
    //                            {
    //                                Start_time="6 AM",End_time="10 AM"
    //                            }
    //                            }
    //                        }
    //                    }
    //                },
    //                new Menu {
    //                    Id = "3",
    //                    Title = "Dinner",
    //                    Category_ids = new List<string> { "3" },
    //                    Service_availablity = new List<ServiceAvailability>
    //                    {
    //                        new ServiceAvailability
    //                        {
    //                            Day_of_week="DAILY",
    //                            Time_periods=new List<TimePeriod>
    //                            { new TimePeriod
    //                            {
    //                                Start_time="12 PM",End_time="4 PM"
    //                            }
    //                            }
    //                        }
    //                    }
    //                }
    //            },
    //            Categories = new List<Category> //type
    //            {
    //                 new Category
    //                 {
    //                    Id="1",
    //                     Title="Egg Dishes",
    //                     Entities=new List<MenuEntity>
    //                     {
    //                         new MenuEntity
    //                         {
    //                             Id="1",
    //                             Type="Category" // it can be category or option
    //                         }
    //                     }
    //                 },
    //                 new Category
    //                 {
    //                    Id="2",
    //                     Title="Soft Drinks",
    //                     Entities=new List<MenuEntity>
    //                     {
    //                         new MenuEntity
    //                         {
    //                             Id="2",
    //                             Type="Category" // it can be category or option
    //                         }
    //                     }
    //                 }
    //            },
    //            Items = new List<Item> //items corresponding to the category
    //            {
    //                 new Item {Id = "1", Title ="scrambled eggs", Image_url="", Price=39.5d },
    //                 new Item {Id = "2", Title ="eggs benediet", Image_url="", Price=39.5d }
    //            },
    //            Options = new List<Options>
    //            {

    //            }
    //        };


    //        return menuConfiguration;
    //    }

    //  }


    public class MenuStream
    {
        public async Task<MenuConfiguration> GetAllMenuAsync()
        {
            MenuConfiguration menuConfiguration = Data.GetSampleData();
            return menuConfiguration;
        }

        public async Task<List<MenuItem>> GetItemByCategory(string categoryId, CancellationToken cancellationToken = default)
        {
            MenuConfiguration menu=Data.GetSampleData();

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
