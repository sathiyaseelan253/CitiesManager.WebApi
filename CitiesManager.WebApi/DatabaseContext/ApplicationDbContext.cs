using CitiesManager.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CitiesManager.WebApi.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions contextOptions) : base(contextOptions)
        {

        }
        public ApplicationDbContext()
        {

        }
        public DbSet<City> Cities { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<City>().HasData(new City() { CityID = Guid.Parse("057FB3C5-115F-4B00-8F35-CC5646D386D1"), CityName = "Brazil" });
            modelBuilder.Entity<City>().HasData(new City() { CityID = Guid.Parse("FC569E5D-75EA-4860-B7B0-A175B1672659"), CityName = "London" });
            modelBuilder.Entity<City>().HasData(new City() { CityID = Guid.Parse("06C704C5-5964-4A41-AB93-63E07CE7B8B8"), CityName = "New Delhi" });
        }
    }
}
