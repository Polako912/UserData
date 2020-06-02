using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserData.Core.Interfaces.Repository;
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
            return await _context.Users.FirstOrDefaultAsync(user => user.UserId == id);
        }

        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task ModifyAsync(User user)
        {
            var ctxUser = await _context.Users.FirstOrDefaultAsync(thisUser => thisUser.UserId == user.UserId);
            if (ctxUser is null)
            {
                throw new ArgumentException($"Is exist {user.UserId}.");
            }

            _context.Users.Update(ctxUser);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(User user)
        {
            var ctxUser = await _context.Users.FirstOrDefaultAsync(thisUser => thisUser.UserId == user.UserId);
            if (ctxUser is null)
            {
                throw new ArgumentException($"Not exist {user.UserId}.");
            }

            _context.Users.Remove(ctxUser);
            await _context.SaveChangesAsync();
        }
    }
}