using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testeOneToOne.interfaces
{
    public interface IGeneralUsers
    {
        void AddUser<T>(T entity) where T : class;

        void UpdateUser<T>(T entity) where T : class;

        void DeleteUser<T>(T entity) where T : class;

        Task<bool> SaveUser();
    }
}
