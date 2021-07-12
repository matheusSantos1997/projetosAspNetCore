using authenticationUsers.Application.Interfaces;
using AuthenticationUsers.Business.models;
using AuthenticationUsers.Data.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace authenticationUsers.Application.Services
{
    public class PostService : IPostService
    {
        private readonly IGenericRepository _generic;

        private readonly IPostRepository _post;

        public PostService(IGenericRepository generic, IPostRepository post)
        {
            _generic = generic;
            _post = post;
        }

        public async Task<Post> AddPost(Post model)
        {
            try
            {
                _generic.Add(model);

                bool save = await _generic.SaveChangesAsync();

                if (save)
                {
                    return await _post.GetPostById(model.Id);
            
                }

                return null;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<Post> UpdatePost(long id, Post model)
        {
            try
            {
                var post = await _post.GetPostById(id);
                model.Id = post.Id;

                if(post == null)
                {
                    return null;
                }

                _generic.Update(model);

                bool save = await _generic.SaveChangesAsync();

                if (save)
                {
                    return await _post.GetPostById(model.Id);
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeletePost(long id)
        {
            try
            {
                var post = await _post.GetPostById(id);

                if (post == null)
                {
                    throw new Exception("Post is not deleted.");
                }

                _generic.Remove(post);

                return await _generic.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Post>> GetAllPosts()
        {
            try
            {
                var posts = await _post.GetAllPosts();

                if (posts == null) return null;

                return posts;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Post>> GetAllPostsByTitle(string title)
        {
            try
            {
                var posts = await _post.GetAllPostsByTitle(title);

                if (posts == null) return null;

                return posts;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Post> GetPostById(long id)
        {
            try
            {
                var post = await _post.GetPostById(id);

                if (post == null) return null;

                return post;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
