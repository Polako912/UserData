using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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

        public Task AddAsync(User user)
        {
            return _userDataRepository.AddAsync(user);
        }

        public Task ModifyAsync(User user)
        {
            return _userDataRepository.ModifyAsync(user);
        }

        public Task DeleteAsync(User user)
        {
            return _userDataRepository.DeleteAsync(user);
        }
    }
}
