using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SrBatata.Abstractions.DataAccess.Repositories;
using SrBatata.AnimalEncyclopedia.Models;
using SrBatata.AnimalEncyclopedia.Storage.Contexts;
using SrBatata.AnimalEncyclopedia.Storage.Repositories;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServicesExtensions
    {
        public static IServiceCollection ConfigureAnimalEncyclopedia(this IServiceCollection services, IConfiguration configuration)
        {
            // Add Animal Encyclopidia context
            services.AddDbContext<AnimalEncyclopediaContext>(options =>
            {
                options.UseApplicationDefaultConfiguration(configuration);
            });

            // Add Animal Repository
            services.AddScoped<IRepository<Animal>, AnimalRepository>();
            return services;
        }
    }
}
