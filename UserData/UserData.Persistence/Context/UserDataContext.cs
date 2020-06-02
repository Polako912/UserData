
using Microsoft.EntityFrameworkCore;
using UserData.Persistence.Extension;
using UserData.Persistence.Settings;
using UserData.Persistence.TableConfig;

namespace UserData.Persistence.Context
{
    public class UserDataContext : DbContext
    {
        private readonly DatabaseConfig _config;
        public DbSet<User> Users { get; set; }

        public UserDataContext(DbContextOptions options, DatabaseConfig config): base(options)
        {
            _config = config;
        }
        
        public void RunMigration()
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfiguration(new UserDataConfiguration())
                .Seed(_config);
        }
    }
}