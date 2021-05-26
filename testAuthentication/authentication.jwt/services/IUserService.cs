using System.Collections.Generic;
using System.Threading.Tasks;
using authentication.jwt.models;

namespace authentication.jwt.services
{
    public interface IUserService
    {
        //  User Signup(User user);
        //  User Login(User user);
        //  List<User> GetAllUsers();
        void Add<T>(T entity) where T : class;

        Task<bool> saveChangesAsync();

        Task<List<User>> GetAllUserAsync(bool b = false);
        
        User Login(User user);
    }
}