using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using UserData.Persistence.Context;
using UserData.Persistence.Settings;

namespace UserData.Persistence.Extension
{
    public static class DatabaseExtension
    {
        public static IApplicationBuilder UseMigrationUserData(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var db = serviceScope.ServiceProvider.GetService<UserDataContext>();
                var dbConfig = app.ApplicationServices.GetService<DatabaseConfig>();
            
                if (dbConfig?.Migrations == true)
                {
                    db?.RunMigration();
                }
            }
            
            return app;
        }
    }
}