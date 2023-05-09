using BusinessLogic.Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReceptenVoorHuisgenoten2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceptController : ControllerBase
    {
        private readonly DataContext Context;

        public ReceptController(DataContext Context)
        {
            this.Context = Context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Recept>>> Get()
        {
            return Ok(await Context.Recepten.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Recept>> Get(int id)
        {
            var recept = await Context.Recepten.FindAsync(id);
            if(recept == null)
            {
                return BadRequest("Recept not found.");
            }
            return Ok(recept);
        }

        [HttpPost]
        public async Task<ActionResult<List<Recept>>> AddRecept(Recept recept)
        {
            Context.Recepten.Add(recept);
            await Context.SaveChangesAsync();

            return Ok(await Context.Recepten.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Recept>>> UpdateRecept(Recept request)
        {
            var dbRecept = await Context.Recepten.FindAsync(request.ID);
            if (dbRecept == null)
            {
                return BadRequest("Recept not found.");
            }

            dbRecept.Naam = request.Naam;
            dbRecept.Duur = request.Duur;
            dbRecept.Moeilijkheid = request.Moeilijkheid;

            await Context.SaveChangesAsync();

            return Ok(await Context.Recepten.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Recept>> Delete(int id)
        {
            var dbRecept = await Context.Recepten.FindAsync(id);
            if (dbRecept == null)
            {
                return BadRequest("Recept not found.");
            }

            Context.Recepten.Remove(dbRecept);
            await Context.SaveChangesAsync();

            return Ok(await Context.Recepten.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Recept>> GetIngredientenByRecept(int id)
        {
            var recept = await Context.Recepten.FindAsync(id);
            if (recept == null)
            {
                return BadRequest("Recept not found.");
            }
            return Ok(recept);
        }
    }
}
