using BusinessLogic.Logic;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace TurfBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigins")]
    public class DrinkController : Controller
    {
        private readonly DataContext Context;

        public DrinkController(DataContext Context)
        {
            this.Context = Context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Drink>>> Get()
        {
            return Ok(await Context.Drinks.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Drink>> Get(int id)
        {
            var Drink = await Context.Drinks.FindAsync(id);
            if (Drink == null)
            {
                return BadRequest("Drink not found.");
            }
            return Ok(Drink);
        }

        [HttpPost]
        public async Task<ActionResult<List<Drink>>> AddDrink(Drink Drink)
        {
            Context.Drinks.Add(Drink);
            await Context.SaveChangesAsync();

            return Ok(await Context.Drinks.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Drink>>> UpdateDrink(Drink request)
        {
            var dbDrink = await Context.Drinks.FindAsync(request.ID);
            if (dbDrink == null)
            {
                return BadRequest("Drink not found.");
            }

            dbDrink.Naam = request.Naam;

            await Context.SaveChangesAsync();

            return Ok(await Context.Drinks.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Drink>> Delete(int id)
        {
            var dbDrink = await Context.Drinks.FindAsync(id);
            if (dbDrink == null)
            {
                return BadRequest("Drink not found.");
            }

            Context.Drinks.Remove(dbDrink);
            await Context.SaveChangesAsync();

            return Ok(await Context.Drinks.ToListAsync());
        }
    }
}
