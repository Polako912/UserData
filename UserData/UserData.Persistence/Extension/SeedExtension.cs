using System;
using Microsoft.EntityFrameworkCore;
using UserData.Persistence.Settings;

namespace UserData.Persistence.Extension
{
    public static class SeedExtension
    {
        public static ModelBuilder Seed(this ModelBuilder modelBuilder, DatabaseConfig config)
        {
            if (!config.Seeder)
            {
                return modelBuilder;
            }
            
            throw new NotImplementedException();

            return modelBuilder;
        }
    }
}