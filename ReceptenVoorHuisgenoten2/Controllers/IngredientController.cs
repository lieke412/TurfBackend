using BusinessLogic.Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IngredientenVoorHuisgenoten2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        private readonly DataContext Context;

        public IngredientController(DataContext Context)
        {
            this.Context = Context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Ingredient>>> Get()
        {
            return Ok(await Context.Ingredienten.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ingredient>> Get(int id)
        {
            var Ingredient = await Context.Ingredienten.FindAsync(id);
            if (Ingredient == null)
            {
                return BadRequest("Ingredient not found.");
            }
            return Ok(Ingredient);
        }

        [HttpPost]
        public async Task<ActionResult<List<Ingredient>>> AddIngredient(Ingredient Ingredient)
        {
            Context.Ingredienten.Add(Ingredient);
            await Context.SaveChangesAsync();

            return Ok(await Context.Ingredienten.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Ingredient>>> UpdateIngredient(Ingredient request)
        {
            var dbIngredient = await Context.Ingredienten.FindAsync(request.ID);
            if (dbIngredient == null)
            {
                return BadRequest("Ingredient not found.");
            }

            dbIngredient.Naam = request.Naam;

            await Context.SaveChangesAsync();

            return Ok(await Context.Ingredienten.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Ingredient>> Delete(int id)
        {
            var dbIngredient = await Context.Ingredienten.FindAsync(id);
            if (dbIngredient == null)
            {
                return BadRequest("Ingredient not found.");
            }

            Context.Ingredienten.Remove(dbIngredient);
            await Context.SaveChangesAsync();

            return Ok(await Context.Ingredienten.ToListAsync());
        }
    }
}
