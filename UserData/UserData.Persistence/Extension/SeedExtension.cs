using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using UserData.Core.Models;
using UserData.Persistence.Settings;

namespace UserData.Persistence.Extension
{
    public static class SeedExtension
    {
        private static Random _random = new Random();
        
        public static ModelBuilder Seed(this ModelBuilder modelBuilder, DatabaseConfig config)
        {
            if (!config.Seeder) return modelBuilder;

            modelBuilder.Entity<User>()
                .HasData(GerenrateUser());
            
            return modelBuilder;
        }

        private static IEnumerable<User> GerenrateUser()
        {
            var users = new List<User>();
            for (var i = 1; i < 101; i++)
            {
                users.Add(new User
                {
                    UserId = i,
                    Age = _random.Next(),
                    Street = RandomString(_random.Next(8,32)),
                    FirstName = RandomString(_random.Next(8,32)),
                    LastName = RandomString(_random.Next(8,32)),
                    StreetNumber = RandomString(2),
                    TelephoneNumber = RandomNumber(9),
                    Username = RandomString(9),
                    EmailAddress = RandomString(9)
                });
            }

            return users;
        }
        
        private static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[_random.Next(s.Length)]).ToArray());
        }

        private static string RandomNumber(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[_random.Next(s.Length)]).ToArray());
        }
    }
}