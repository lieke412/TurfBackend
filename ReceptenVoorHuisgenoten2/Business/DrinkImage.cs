using System.ComponentModel.DataAnnotations;

namespace TurfBackEnd.Business
{
    public class DrinkImage
    {
        [Key][Required] public Guid ID { get; set; }
        public Guid DrinkID { get; set; }
        [Required] public string ImageUrl { get; set; }
        [Required] public Drink Drink { get; set; }

        public DrinkImage(string imageUrl, Guid drinkID)
        {
            ImageUrl = imageUrl;
            DrinkID = drinkID;
        }
    }
}
