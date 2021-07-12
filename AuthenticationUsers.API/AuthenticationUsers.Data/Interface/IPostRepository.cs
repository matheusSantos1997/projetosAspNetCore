using AuthenticationUsers.Business.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationUsers.Data.Interface
{
    public interface IPostRepository
    {
        Task<List<Post>> GetAllPosts();

        Task<List<Post>> GetAllPostsByTitle(string title);

        Task<Post> GetPostById(long id);
    }
}
