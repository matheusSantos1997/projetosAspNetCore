using System.Collections.Generic;
using System.Threading.Tasks;
using authentication.jwt.models;

namespace authentication.jwt.services
{
    public interface IUserService
    {
        void Add<T>(T entity) where T : class;

        Task<bool> saveChangesAsync();

        Task<List<User>> GetAllUserAsync(bool b = false);
        
        Task<User> Login(User user);
    }
}