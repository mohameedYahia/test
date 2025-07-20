using Microsoft.Extensions.DependencyInjection;

namespace DatabaseSystem.Infrastructure
{
    public static class Infrastructure
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            // Register your database context and repository implementations here
            // Example:
            // services.AddDbContext<YourDbContext>(options =>
            //     options.UseSqlServer("YourConnectionString"));

            // services.AddScoped<IYourRepository, YourRepository>();
        }
    }
}