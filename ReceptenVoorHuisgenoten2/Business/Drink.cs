using System.ComponentModel.DataAnnotations;

namespace TurfBackEnd.Business
{
    public class Drink
    {
        [Key][Required] public Guid ID { get; set; }
        [Required] public string Name { get; set; }
        public int Price { get; set; }
        public virtual ICollection<DrinkImage> Images { get; set; }

        public Drink()
        {

        }

    }
}
