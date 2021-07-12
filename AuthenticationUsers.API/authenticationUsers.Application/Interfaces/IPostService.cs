using AuthenticationUsers.Business.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace authenticationUsers.Application.Interfaces
{
    public interface IPostService
    {
        Task<Post> AddPost(Post model);

        Task<Post> UpdatePost(long id, Post model);

        Task<bool> DeletePost(long id);

        Task<List<Post>> GetAllPosts();

        Task<List<Post>> GetAllPostsByTitle(string title);

        Task<Post> GetPostById(long id);
    }
}
