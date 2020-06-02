using System.Threading.Tasks;
using UserData.Core.Models;

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