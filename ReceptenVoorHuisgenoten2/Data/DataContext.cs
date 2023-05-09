using BusinessLogic.Logic;
using Microsoft.EntityFrameworkCore;

namespace ReceptenVoorHuisgenoten2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Recept> Recepten { get; set; }
        public DbSet<Ingredient> Ingredienten { get; set; }
        //public DbSet<ReceptIngredient> ReceptIngredienten { get; set; }
    }
}
