using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserData.Core.Commands;
using UserData.Core.Interfaces.Repository;
using UserData.Core.Models;
using UserData.Persistence.Context;

namespace UserData.Persistence.Repository
{
    public class UserDataRepository : IUserDataRepository
    {
        private readonly UserDataContext _context;

        public UserDataRepository(UserDataContext context)
        {
            _context = context;
        }

        public async Task<User> GetAsync(int id)
        {
            return await _context.UsersData.FirstOrDefaultAsync(user => user.UserId == id);
        }

        public async Task AddAsync(UserCommand user)
        {
            var userValid = new User
            {
                Age = user.Age,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Street = user.Street,
                StreetNumber = user.StreetNumber,
                TelephoneNumber = user.TelephoneNumber,
                Username = user.Username,
                EmailAddress = user.EmailAddress
            };

            await _context.UsersData.AddAsync(userValid);
            await _context.SaveChangesAsync();
        }

        public async Task ModifyAsync(User user)
        {
            var ctxUser = await _context.UsersData.FirstOrDefaultAsync(thisUser => thisUser.UserId == user.UserId);
            if (ctxUser is null) throw new ArgumentException($"Is exist {user.UserId}.");

            ctxUser.Age = user.Age;
            ctxUser.Street = user.Street;
            ctxUser.Username = user.Username;
            ctxUser.EmailAddress = user.EmailAddress;
            ctxUser.FirstName = user.FirstName;
            ctxUser.LastName = user.LastName;
            ctxUser.StreetNumber = user.StreetNumber;
            ctxUser.TelephoneNumber = user.TelephoneNumber;

            _context.UsersData.Update(ctxUser);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(User user)
        {
            var ctxUser = await _context.UsersData.FirstOrDefaultAsync(thisUser => thisUser.UserId == user.UserId);
            if (ctxUser is null) throw new ArgumentException($"Not exist {user.UserId}.");

            _context.UsersData.Remove(ctxUser);
            await _context.SaveChangesAsync();
        }
    }
}