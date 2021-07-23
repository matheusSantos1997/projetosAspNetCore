using authenticationUsers.Application.Interfaces;
using AuthenticationUsers.Business.models;
using AuthenticationUsers.Data.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace authenticationUsers.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository _generic;

        private readonly IUserRepository _user;

        public UserService(IGenericRepository generic, IUserRepository user)
        {
            _generic = generic;
            _user = user;
        }

        public async Task<User> SignUp(User user)
        {
            try
            {
                user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);

                _generic.Add(user);

                bool save = await _generic.SaveChangesAsync();

                if (save)
                {
                    return await _user.GetUserById(user.Id);
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<User> SignIn(User user)
        {
            try
            {
                var userOne = await _user.Authentication(user);

                if (userOne != null)
                {
                    return userOne;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<User> UpdateUser(long id, User model)
        {
            try
            {
                var user = await _user.GetUserById(id);
                model.Id = user.Id;

                if (user == null)
                {
                    return null;
                }

                _generic.Update(model);

                bool save = await _generic.SaveChangesAsync();

                if (save)
                {
                    return await _user.GetUserById(model.Id);
                }

                return null;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<User> GetUserById(long id)
        {
            try
            {
                var user = await _user.GetUserById(id);

                if (user == null) return null;

                return user;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
