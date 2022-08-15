using Microsoft.Extensions.Configuration;

namespace Microsoft.EntityFrameworkCore
{
    public static class DbContextOptionsBuilderExtension
    {
        public static DbContextOptionsBuilder UseApplicationDefaultConfiguration(this DbContextOptionsBuilder options, IConfiguration configuration)
        {
            // options.UseLazyLoadingProxies();
            return options
                .UseSqliteDatabase(configuration);
        }

        public static DbContextOptionsBuilder UseSqliteDatabase(this DbContextOptionsBuilder options, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("SqliteConnectionString");
            return options.UseSqlite(connectionString);
        }
    }
}
