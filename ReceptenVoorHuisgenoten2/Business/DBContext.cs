using Microsoft.EntityFrameworkCore;

namespace TurfBackEnd.Business
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<Drink> Drinks { get; set; }
        public virtual DbSet<DrinkImage> DrinkImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Drink>().Property(Drinks => Drinks.ID).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<DrinkImage>().Property(DrinkImage => DrinkImage.ID).HasDefaultValueSql("NEWID()");
        }
    }
}
