using System.Threading.Tasks;
using UserData.Core.Commands;
using UserData.Core.Models;

namespace UserData.Core.Interfaces.Services
{
    public interface IUserService
    {
        Task<User> GetAsync(int id);
        Task AddAsync(UserCommand user);
        Task ModifyAsync(User user);
        Task DeleteAsync(User user);
    }
}