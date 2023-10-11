using TurfBackEnd.Business;
using TurfBackEnd.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace TurfBackEnd.Repositories
{
    public class DrinkRepository : DBContext, IDrinkRepository
    {
        public DrinkRepository(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public List<Drink> GetAllDrinks()
        {
            return Drinks.ToList();
        }

        public Drink GetDrinkByID(Guid drinkID)
        {
            Drink drink = Drinks.Where(d => d.ID == drinkID).FirstOrDefault();
            drink.Images = GetDrinkImageByDrinkID(drinkID);
            return drink;
        }

        public DrinkImage CreateDrinkImage(DrinkImage imageEntity)
        {
            DrinkImages.Add(imageEntity);
            Save();
            return imageEntity;
        }

        public List<DrinkImage> GetDrinkImageByDrinkID(Guid drinkID)
        {
            return DrinkImages.Where(d => d.DrinkID == drinkID).ToList();
        }

        public void Save()
        {
            SaveChanges(true);
        }

        public void Save(bool acceptChangesOnSuccess)
        {
            SaveChanges(acceptChangesOnSuccess);
        }
    }
}
