using AuthenticationUsers.Business.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationUsers.Data.Interface
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsers();

        Task<List<User>> GetAllUsersByName(string name);

        Task<User> GetUserById(long id);

        Task<User> Authentication(User user);
    }
}
