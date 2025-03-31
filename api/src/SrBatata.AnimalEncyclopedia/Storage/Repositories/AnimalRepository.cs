using SrBatata.Abstractions.DataAccess.Repositories;
using SrBatata.AnimalEncyclopedia.Models;
using SrBatata.AnimalEncyclopedia.Storage.Contexts;

namespace SrBatata.AnimalEncyclopedia.Storage.Repositories
{
    internal class AnimalRepository : RepositoryBase<Animal, AnimalEncyclopediaContext>
    {
        public AnimalRepository(AnimalEncyclopediaContext context) : base(context)
        {
        }
    }
}
