using Core.Repositories;
using Infrastructure.Context;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace TechChallange
{
    public static class IoC
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IRegionalContactsRepository, RegionalContactsRepository>();
            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();

            services.AddDbContext<ApplicationDbContext>(provider =>
                provider.UseNpgsql(configuration.GetSection("DbContextSettings").GetSection("ConnectionString").Value),
                ServiceLifetime.Scoped
            );

            return services;
        }
    }
}
