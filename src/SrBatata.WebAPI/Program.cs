using Microsoft.AspNetCore;

namespace SrBatata.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var app = BuildWebApplication(args);

            ConfigureMiddleware(app, app.Environment, app.Services);
            ConfigureEndpoints(app, app.Services);

            app.Run();
        }

        public static WebApplication BuildWebApplication(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            ConfigureConfiguration(builder.Configuration);
            ConfigureServices(builder.Services);

            return builder.Build();
        }

        private static void ConfigureConfiguration(ConfigurationManager configuration) 
        {
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Add services to the container.
            services.AddControllers();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }

        private static void ConfigureMiddleware(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider services)
        {
            // Configure the swagger.
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // Configure the HTTP request pipeline.
            app.UseHttpsRedirection();

            app.UseAuthorization();
        }

        private static void ConfigureEndpoints(IEndpointRouteBuilder app, IServiceProvider services)
        {
            app.MapControllers();
        }
    }
}