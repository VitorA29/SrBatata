using System.ComponentModel.DataAnnotations;
using SrBatata.Abstractions.DataAccess.Models;
using SrBatata.AnimalEncyclopedia.Abstractions;

namespace SrBatata.AnimalEncyclopedia.Models
{
    public record Animal : Entity
    {
        public string Name { get; set; }

        [EnumDataType(typeof(AnimalSpecies))]
        public AnimalSpecies Species { get; set; }
    }
}
