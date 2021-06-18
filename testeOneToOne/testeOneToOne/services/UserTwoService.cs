using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testeOneToOne.context;
using testeOneToOne.interfaces;
using testeOneToOne.models;

namespace testeOneToOne.services
{
    public class UserTwoService : IUserTwo
    {
        private readonly UserContext _context;

        public UserTwoService(UserContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public async Task<List<UserTwo>> GetAllUsersTwo()
        {
            List<UserTwo> userAll = new List<UserTwo>();

            userAll = await _context.UsersTwo.AsNoTracking()
                                    .Include(u => u.UserOne)
                                    .OrderBy(u => u.idUserTwo)
                                    .ToListAsync();
            return userAll;
        }

        public async Task<List<UserTwo>> GetAllUserTwoByName(string name)
        {
            List<UserTwo> userName = new List<UserTwo>();

            userName = await _context.UsersTwo.AsNoTracking()
                                     .Include(u => u.UserOne)
                                     .OrderBy(u => u.idUserTwo)
                                     .Where(u => u.Name.ToLower().Contains(name.ToLower()))
                                     .ToListAsync();
            return userName;
        }

        public async Task<UserTwo> GetUserTwoById(int id)
        {
            var userId = await _context.UsersTwo.AsNoTracking()
                                       .Include(u => u.UserOne)
                                       .OrderBy(u => u.idUserTwo)
                                       .Where(u => u.idUserTwo == id)
                                       .FirstOrDefaultAsync();
            return userId;
                                    
        }
    }
}
