using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testeOneToOne.models;

namespace testeOneToOne.interfaces
{
    public interface IUserOne
    {
        Task<List<UserOne>> GetAllUsersOne(bool b = false);

        Task<List<UserOne>> GetAllUserOneByName(string name, bool b = false);

        Task<UserOne> GetUserOneById(int id, bool b = false);
    }
}
