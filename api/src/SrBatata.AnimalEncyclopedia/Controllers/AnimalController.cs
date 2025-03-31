using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SrBatata.Abstractions.DataAccess.Repositories;
using SrBatata.AnimalEncyclopedia.Abstractions;
using SrBatata.AnimalEncyclopedia.Models;

namespace SrBatata.AnimalEncyclopedia.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimalController : ControllerBase
    {
        private readonly ILogger<AnimalController> _logger;
        private readonly IRepository<Animal> _repository;

        public AnimalController(ILogger<AnimalController> logger, IRepository<Animal> repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Animal>> Get()
        {
            return Ok(_repository.GetAll());
        }

        [HttpPost]
        public IActionResult Post()
        {
            _repository.Add(new Animal
            {
                Name = Random.Shared.Next().ToString(),
                Species = (AnimalSpecies) Random.Shared.Next(1, 3)
            });
            _repository.SaveChanges();

            return Accepted();
        }
    }
}
