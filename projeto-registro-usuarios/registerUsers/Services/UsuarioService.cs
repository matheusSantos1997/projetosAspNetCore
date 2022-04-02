using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using registerUsers.Interfaces;
using registerUsers.Models;

namespace registerUsers.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<List<Usuario>> GetAllUsers()
        {
            try 
            {
                var users = await _usuarioRepository.GetAll();

                if(users == null)
                {
                   return null;
                }

                return users;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Usuario> GetUserById(int id)
        {
           try
           {
               var user = await _usuarioRepository.GetById(id);

               if(user == null) return null;

               return user;
           }
           catch(Exception ex)
           {
               throw new Exception(ex.Message);
           }
        }

        public async Task<List<Usuario>> GetUserByName(string name)
        {
            try
            {
                var users = await _usuarioRepository.GetByName(name);

                if(users == null) return null;

                return users;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Usuario> InsertUser(Usuario model)
        {
            try
            {
               _usuarioRepository.Add(model);

               bool save = await _usuarioRepository.SaveChangesAsync();

               if(save)
               {
                   return await _usuarioRepository.GetById(model.IdUsuario);
               }

               return null;
                
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Usuario> UpdateUser(int id, Usuario model)
        {
            try
            {
                var user = await _usuarioRepository.GetById(id);

                model.IdUsuario = user.IdUsuario;

                if(user == null)
                {
                   return null;
                } 

                _usuarioRepository.Update(model);

                bool save = await _usuarioRepository.SaveChangesAsync();

                if (save)
                {
                    return await _usuarioRepository.GetById(model.IdUsuario);
                }

                return null;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteUser(int id)
        {
            try
            {
                var user = await _usuarioRepository.GetById(id);

                if(user == null)
                {
                    throw new Exception("User is not deleted");
                }

                _usuarioRepository.Remove(user);

                return await _usuarioRepository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}