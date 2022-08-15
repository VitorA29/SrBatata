using SrBatata.Abstractions.Storage;
using SrBatata.AnimalEncyclopedia.Models;
using SrBatata.AnimalEncyclopedia.Storage.Contexts;

namespace SrBatata.AnimalEncyclopedia.Storage.Repositories
{
    internal class AnimalRepository : Repository<Animal>
    {
        public AnimalRepository(AnimalEncyclopediaContext context) : base(context)
        {
        }
    }
}
