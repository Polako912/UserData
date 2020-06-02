using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserData.Core.Interfaces.Repository
{
    public interface IUserDataRepository
    {
        Task<User> GetAsync(int id);
        Task AddAsync(User user);
        Task ModifyAsync(User user);
        Task DeleteAsync(User user);
    }
}
