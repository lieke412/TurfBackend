using TurfBackEnd.Models;

namespace TurfBackEnd.Interfaces
{
    public interface IDrinkService
    {
        List<DrinkModel> GetAllDrinks();
        DrinkModel GetDrinkByID(Guid drinkID);

    }
}
