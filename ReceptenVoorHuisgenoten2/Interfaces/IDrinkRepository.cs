using TurfBackEnd.Business;

namespace TurfBackEnd.Interfaces
{
    public interface IDrinkRepository
    {
        List<Drink> GetAllDrinks();
        Drink GetDrinkByID(Guid drinkID);
        List<DrinkImage> GetDrinkImageByDrinkID(Guid drinkID);
        void Save();
        void Save(bool acceptChangesOnSuccess);
    }
}
