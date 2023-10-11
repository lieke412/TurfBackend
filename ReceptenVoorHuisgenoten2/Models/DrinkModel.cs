using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using TurfBackEnd.Business;

namespace TurfBackEnd.Models
{
    public class DrinkModel
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public List<string> Images { get; set; }

        public DrinkModel(Guid iD, string name, int price, List<string> images)
        {
            ID = iD;
            Name = name;
            Price = price;
            Images = images;
        }

        public DrinkModel(string name, int price, List<string> images)
        {
            Name = name;
            Price = price;
            Images = images;
        }

        public DrinkModel(Drink drink)
        {
            ID = drink.ID;
            Name = drink.Name;
            Price = drink.Price;
            Images = new List<string>();
            if(drink.Images != null)
            {
                foreach(DrinkImage image in drink.Images)
                {
                    Images.Add(image.ImageUrl);
                }
            }
        }
    }
}
