using BusinessLogic.Logic;
using Microsoft.EntityFrameworkCore;

namespace ReceptenVoorHuisgenoten2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Recept> Recepten { get; set; }
        public DbSet<Ingredient> Ingredienten { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredient>()
                .HasMany(i => i.Recepten)
                .WithMany(r => r.Ingredienten)
                .UsingEntity(j => j.ToTable("IngredientRecept"));
        }
    }
}
