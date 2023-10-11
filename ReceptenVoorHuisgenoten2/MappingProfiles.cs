using AutoMapper;

namespace TurfBackEnd
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Business.Drink, Models.DrinkModel>();
            CreateMap<Models.DrinkModel, Business.Drink>();
        }
    }
}
