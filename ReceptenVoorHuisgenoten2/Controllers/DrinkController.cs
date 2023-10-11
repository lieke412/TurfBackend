using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using TurfBackEnd.Interfaces;

namespace TurfBackEnd.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DrinkController : Controller
    {
        private readonly IDrinkService DrinkService;
        private readonly IMapper Mapper;

        public DrinkController(IDrinkService drinkLogic, IMapper mapper )
        {
            DrinkService = drinkLogic;
            Mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(DrinkService.GetAllDrinks());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetDrinkByID(Guid ID)
        {
            return Ok(DrinkService.GetDrinkByID(ID));
        }
    }
}
