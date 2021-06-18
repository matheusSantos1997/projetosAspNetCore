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
    public class UserOneService : IUserOne
    {
        private readonly UserContext _context;

        public UserOneService(UserContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public async Task<List<UserOne>> GetAllUserOneByName(string name, bool b)
        {
            List<UserOne> userName = new List<UserOne>();
            userName = await _context.UsersOne.AsNoTracking()
                                         .Include(u => u.UserTwo)
                                         .OrderBy(u => u.idUserOne)
                                         .Where(u => u.Name.ToLower().Contains(name.ToLower()))
                                         .ToListAsync();

            return userName;
        }

        public async Task<List<UserOne>> GetAllUsersOne(bool b = false)
        {
            List<UserOne> userAll = new List<UserOne>();
            userAll = await _context.UsersOne.AsNoTracking()
                                        .Include(u => u.UserTwo)
                                        .OrderBy(u => u.idUserOne)
                                        .ToListAsync();

            return userAll;
        }

        public async Task<UserOne> GetUserOneById(int id, bool b = false)
        {
             var userId = await _context.UsersOne.AsNoTracking()
                                       .Include(u => u.UserTwo)
                                       .OrderBy(u => u.idUserOne)
                                       .Where(u => u.idUserOne == id)
                                       .FirstOrDefaultAsync();
                                       
            return userId;
        }
    }
}
