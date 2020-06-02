using System.Threading.Tasks;
using UserData.Core.Commands;
using UserData.Core.Models;

namespace UserData.Core.Interfaces.Repository
{
    public interface IUserDataRepository
    {
        Task<User> GetAsync(int id);
        Task AddAsync(UserCommand user);
        Task ModifyAsync(User user);
        Task DeleteAsync(User user);
    }
}