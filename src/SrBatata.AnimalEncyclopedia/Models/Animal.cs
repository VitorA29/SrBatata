using SrBatata.AnimalEncyclopedia.Abstractions;
using SrBatata.Data.Models;

namespace SrBatata.AnimalEncyclopedia.Models
{
    public record class Animal : Entity
    {
        public string Name { get; set; }
        public AnimalSpecies Species { get; set; }
    }
}
