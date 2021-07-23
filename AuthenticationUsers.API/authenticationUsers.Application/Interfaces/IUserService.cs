using AuthenticationUsers.Business.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace authenticationUsers.Application.Interfaces
{
    public interface IUserService
    {
        Task<User> SignUp(User user);

        Task<User> SignIn(User user);

        Task<User> UpdateUser(long id, User model);

        Task<User> GetUserById(long id);



    }
}
