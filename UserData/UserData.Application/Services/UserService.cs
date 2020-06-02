using System.Threading.Tasks;
using UserData.Core.Commands;
using UserData.Core.Interfaces.Repository;
using UserData.Core.Interfaces.Services;
using UserData.Core.Models;

namespace UserData.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserDataRepository _userDataRepository;

        public UserService(IUserDataRepository userDataRepository)
        {
            _userDataRepository = userDataRepository;
        }

        public Task<User> GetAsync(int id)
        {
            return _userDataRepository.GetAsync(id);
        }

        public async Task AddAsync(UserCommand user)
        {
            await _userDataRepository.AddAsync(user);
        }

        public async Task ModifyAsync(User user)
        {
            await _userDataRepository.ModifyAsync(user);
        }

        public async Task DeleteAsync(User user)
        {
            await _userDataRepository.DeleteAsync(user);
        }
    }
}