using AutoMapper;
using TurfBackEnd.Business;
using TurfBackEnd.Interfaces;
using TurfBackEnd.Models;

namespace TurfBackEnd.Logic
{
    public class DrinkService : IDrinkService
    {
        private readonly IMapper Mapper;
        private readonly IDrinkRepository DrinkRepository;

        public DrinkService(IMapper mapper, IDrinkRepository drinkRepository)
        {
            Mapper = mapper;
            DrinkRepository = drinkRepository;
        }

        public List<DrinkModel> GetAllDrinks()
        {
            List<DrinkModel> result = new List<DrinkModel>();
            foreach (Drink drink in DrinkRepository.GetAllDrinks())
            {
                drink.Images = GetDrinkImageByDrinkID(drink.ID);
                result.Add(new DrinkModel(drink));
            }
            return result;
        }

        public DrinkModel GetDrinkByID(Guid drinkID)
        {
            Drink drink = DrinkRepository.GetDrinkByID(drinkID);
            return new DrinkModel(drink);
        }

        private List<DrinkImage> GetDrinkImageByDrinkID(Guid drinkID)
        {
            return DrinkRepository.GetDrinkImageByDrinkID(drinkID);
        }
    }
}
