using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using UserData.Application.Services;
using UserData.Core.Interfaces.Repository;
using UserData.Core.Interfaces.Services;
using UserData.Persistence.Context;
using UserData.Persistence.Repository;
using UserData.Persistence.Settings;

namespace UserData.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddConfigs(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<DatabaseConfig>(
                configuration.GetSection(nameof(DatabaseConfig)));

            services
                .AddSingleton(sp => sp.GetRequiredService<IOptions<DatabaseConfig>>().Value);

            return services;
        }

        public static IServiceCollection AddContext(this IServiceCollection services, string projectName)
        {
            var config = services.BuildServiceProvider().GetService<DatabaseConfig>();

            services.AddDbContext<UserDataContext>(options =>
                options.UseSqlServer(config.Connection, x
                    => x.MigrationsAssembly(projectName)));

            return services;
        }

        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IUserDataRepository, UserDataRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}