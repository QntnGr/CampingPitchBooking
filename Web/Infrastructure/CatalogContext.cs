using Microsoft.EntityFrameworkCore;
using Web.Entities;

namespace Web.Infrastructure
{
    public class CatalogContext: DbContext
    {
        public DbSet<CampingPitch> CampingPitches { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Localisation> Localisations { get; set; }
        public DbSet<Price> Prices { get; set; }
        public string DbPath { get; }

        public CatalogContext(DbContextOptions<CatalogContext> options) : base(options)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "camping.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

    }
}
