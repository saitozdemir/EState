using EntityLayer.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Data
{
    public class DataContext:IdentityDbContext<UserAdmin>
    {
        public DataContext()
        {
            
        }
        public DataContext(DbContextOptions options) : base(options) {Database.EnsureCreated();}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("A FALLBACK CONNECTION STRING");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Advert> Adverts { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<GeneralSettings> GeneralSettings { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<Neighbourhood> Neighbourhoods { get; set; }
        public DbSet<Situation> Situations { get; set; }
        public DbSet<EntityLayer.Entity.Type> Types { get; set; }
        public DbSet<UserAdmin> UserAdmins { get; set; }
    }
}
