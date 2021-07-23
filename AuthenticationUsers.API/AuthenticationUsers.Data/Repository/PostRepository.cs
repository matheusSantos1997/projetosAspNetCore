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
    public class PostRepository : IPostRepository
    {
        private readonly AuthenticationDbContext _context;

        public PostRepository(AuthenticationDbContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public async Task<List<Post>> GetAllPosts()
        {
            IQueryable<Post> query = _context.Posts.AsNoTracking();
        
            query = query.Include(p => p.User).OrderBy(p => p.Id);

            return await query.ToListAsync();
        }

        public async Task<List<Post>> GetAllPostsByTitle(string title)
        {
            IQueryable<Post> query = _context.Posts.AsNoTracking();

            query = query.Include(p => p.User).Where(p => p.Title.ToLower().Contains(title.ToLower()));
                                           
            return await query.ToListAsync();
        }

        public async Task<Post> GetPostById(long id)
        {
            IQueryable<Post> query = _context.Posts.AsNoTracking();


            query = query.Include(p => p.User).Where(p => p.Id == id);
                                           
            return await query.FirstOrDefaultAsync();
        }
    }
}
