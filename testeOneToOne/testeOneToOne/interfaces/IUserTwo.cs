using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testeOneToOne.models;

namespace testeOneToOne.interfaces
{
    public interface IUserTwo
    {
        Task<List<UserTwo>> GetAllUsersTwo();

        Task<List<UserTwo>> GetAllUserTwoByName(string name);

        Task<UserTwo> GetUserTwoById(int id);
    }
}
