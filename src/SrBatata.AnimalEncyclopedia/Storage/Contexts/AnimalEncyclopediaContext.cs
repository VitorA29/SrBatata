using Microsoft.EntityFrameworkCore;
using SrBatata.AnimalEncyclopedia.Models;

namespace SrBatata.AnimalEncyclopedia.Storage.Contexts
{
    internal class AnimalEncyclopediaContext : DbContext
    {
        public DbSet<Animal> Animals { get; protected set; }

        public AnimalEncyclopediaContext(DbContextOptions<AnimalEncyclopediaContext> options) : base(options)
        {
        }
    }
}
