using AuthenticationUsers.Business.models;
using AuthenticationUsers.Data.Context;
using AuthenticationUsers.Data.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationUsers.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AuthenticationDbContext _context;

        public UserRepository(AuthenticationDbContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public async Task<User> GetUserById(long id)
        {
            var user = await _context.Users.AsNoTracking()
                                           .Include(u => u.Posts)
                                           .OrderBy(u => u.Id)
                                           .Where(u => u.Id == id)
                                           .FirstOrDefaultAsync();
            return user;
        }

        public async Task<User> Authentication(User user)
        {
            var userOne = await _context.Users.SingleOrDefaultAsync(x => x.Email == user.Email);

            bool isValidPassword = BCrypt.Net.BCrypt.Verify(user.Password, userOne.Password);

            if (isValidPassword)
            {
                return userOne;
            }

            return null;
        }
    }
}
