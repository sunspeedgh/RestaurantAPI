namespace RestaurantAPI.Models
{

    public class Menu
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class Section
    {       
        public string Id { get; set; } 
        public string Name { get; set; }
        public string Type { get; set; }
        public string MenuId { get; set; }
       

    }

    public class MenuCategory
    {
        public string Id { get; set; }
        public List<string> MenuIds { get; set; }
        public MenuItem MenuItem { get; set; }

    }

    public class MenuDish 
    {
        public string MenuId { get; set; }
      public string Dishid { get; set; }
        public MenuItem MenuItem { get; set; }
        //public ItemPrice Price { get; set; }
    }

    public class MenuOption
    {
        public string OptionId { get; set; }
        public MenuItem MenuItem { get; set; }       
       // public ItemPrice Price { get; set; }    

    }
    public class MenuItem
    {
        public string Id { get; set; }
        public string Name { get; set; }       

        public string SectionId { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

    }

    public class Price
    {
        public string Id { get; set; }
        public string ItemId { get; set; }
        public double Rate { get; set; }

    }

    public class Offer
    {
        public string Id { get; set; }
        public string ItemId { get; set; }
        public string Description { get; set; }
    }

    public class Rating
    {
        public string Id { get; set; }
        public string ItemId { get; set; }
        public string Comments { get; set; }
    }

    public class MenuConfiguration
    {
        public List<Menu> Menu { get; set; }
        public List<Section> Section { get; set; }        
      
        public List<MenuItem> Items { get; set; }
        public List<Price> Prices { get; set; }
        public List<Offer> Offers { get; set; }
        public List<Rating> Rating { get; set; }


    }
}
