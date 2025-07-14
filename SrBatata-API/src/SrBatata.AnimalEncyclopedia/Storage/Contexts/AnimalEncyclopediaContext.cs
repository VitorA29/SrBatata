using Microsoft.EntityFrameworkCore;
using SrBatata.AnimalEncyclopedia.Models;

namespace SrBatata.AnimalEncyclopedia.Storage.Contexts
{
    internal class AnimalEncyclopediaContext : DbContext
    {
        public DbSet<Animal> Animals { get; }

        public AnimalEncyclopediaContext(DbContextOptions<AnimalEncyclopediaContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Animal>()
                .Property(c => c.Species)
                .HasConversion<string>();
        }
    }
}
