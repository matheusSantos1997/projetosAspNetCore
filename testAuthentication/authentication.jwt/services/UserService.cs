using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using authentication.jwt.models;
using Microsoft.EntityFrameworkCore;

namespace authentication.jwt.services
{
    public class UserService : IUserService
    {
        private readonly UserContext context;
        public UserService(UserContext _context)
        {
            context = _context;
        }

        public void Add<T>(T entity) where T : class
        {
            context.Add(entity);
        }

        public async Task<bool> saveChangesAsync()
        {
            bool results = await context.SaveChangesAsync() > 0;
            return results;
        }

        public async Task<List<User>> GetAllUserAsync(bool b = false)
        {
            IQueryable<User> query = context.User;

            query = query.OrderBy(c => c.Id);

            return await query.ToListAsync();
        }

        public async Task<User> Login(User user)
        {
            var userOne = await context.User.SingleOrDefaultAsync(x => x.UserName == user.UserName);

            bool isValidPassword = BCrypt.Net.BCrypt.Verify(user.Password, userOne.Password);

            if (isValidPassword)
            {
                return userOne;
            }

            return null;
        }

    }
}