using System;
using System.Threading.Tasks;
using GaleriaImagens.Application.Interfaces;
using GaleriaImagens.Business.DTOS;
using GaleriaImagens.Business.Models;
using GaleriaImagens.Repository.Interfaces;

namespace GaleriaImagens.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IRepositoryGeneric _generic;
        
        private readonly IUsuarioRepository _usuario;

        public UsuarioService(IRepositoryGeneric generic, IUsuarioRepository usuario)
        {
            _generic = generic;
            _usuario = usuario;
        }

        public async Task<Usuario> SignUp(UsuarioDTO user)
        {
            try
            {
                Usuario usuario = new()
                {
                    Nome = user.Nome,
                    Email = user.Email,
                    CPF = user.CPF,
                    Profissao = user.Profissao,
                    NomeUsuario = user.NomeUsuario,
                    Senha = user.Senha
                };

                usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);

                _generic.Add(usuario);

                bool save = await _generic.SaveChangesAsync();

                if(save)
                {
                    return await _usuario.GetUsuarioById(usuario.Id);
                }

                return null;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Usuario> SignIn(UsuarioLoginDTO user)
        {
            try
            {
                var usuario = await _usuario.Autenticacao(user);

                if(usuario != null)
                {
                    return usuario;
                }

                return null;
            }
            catch (NullReferenceException ex)
            {
                throw new NullReferenceException(ex.Message);
            }
        }

        public async Task<Usuario> UpdateUser(long id, Usuario user)
        {
            try
            {
                var usuario = await _usuario.GetUsuarioById(id);
                user.Id = usuario.Id;

                if(usuario == null)
                {
                    return null;
                }

                _generic.Update(user);

                bool save = await _generic.SaveChangesAsync();

                if(save)
                {
                    return await _usuario.GetUsuarioById(user.Id);
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Usuario> GetUserById(long id)
        {
            try
            {
                var usuario = await _usuario.GetUsuarioById(id);
                
                if(usuario == null) return null;

                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Usuario> GetByEmail(string email)
        {
            try
            {
                var emailExiste = await _usuario.GetUsuarioByEmail(email);

                if (string.IsNullOrEmpty(email))
                {
                    return null;
                }

                return emailExiste;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}