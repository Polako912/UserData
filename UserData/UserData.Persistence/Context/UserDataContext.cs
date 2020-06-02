using Microsoft.EntityFrameworkCore;
using UserData.Core.Models;
using UserData.Persistence.Extension;
using UserData.Persistence.Settings;
using UserData.Persistence.TableConfig;

namespace UserData.Persistence.Context
{
    public class UserDataContext : DbContext
    {
        private readonly DatabaseConfig _config;

        public UserDataContext(DbContextOptions options, DatabaseConfig config) : base(options)
        {
            _config = config;
        }

        public DbSet<User> UsersData { get; set; }

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