using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserData.Core.Interfaces.Repository
{
    public interface IUserDataRepository
    {
        Task<User> Get(int id);
        Task Add(User user);
        Task Modify(User user);
        Task Delete(User user);
    }
}
