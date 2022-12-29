using cursoDapper.ConnectionDB;
using cursoDapper.Interfaces;
using cursoDapper.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace cursoDapper.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IDbConnection _connection;

        public UsuarioRepository()
        {
            _connection = ConnDB.GetConnection();
        }

        public  List<Usuario> GetUsuarios()
        {
            List<Usuario> usuarios = new();

            // caso existir a class model UsuariosDepartamentos => many to many
            // string sql = "SELECT * FROM Usuarios as U LEFT JOIN Contatos as C ON C.UsuarioId = U.Id LEFT JOIN EnderecosEntrega as EE ON EE.UsuarioId = U.Id LEFT JOIN UsuariosDepartamentos as UD ON UD.UsuarioId = U.Id LEFT JOIN Departamentos as D ON UD.DepartamentoId = D.Id";

            /* precisou ser feito dessa forma pois a tabela UsuariosDepartamentos nao possui model 
             * object para o dapper poder mapear assim retorna as informaçoes nulas
             * */
            string sql = @"SELECT U.*, C.*, EE.*, D.* FROM Usuarios as U 
                                                      LEFT JOIN Contatos as C ON C.UsuarioId = U.Id 
                                                      LEFT JOIN EnderecosEntrega as EE ON EE.UsuarioId = U.Id 
                                                      LEFT JOIN UsuariosDepartamentos as UD ON UD.UsuarioId = U.Id 
                                                      LEFT JOIN Departamentos as D ON UD.DepartamentoId = D.Id";

             _connection.Query<Usuario, Contato, EnderecoEntrega, Departamento, Usuario>(sql,
                (usuario, contato, enderecoEntrega, departamento) =>
                {
                    // verificaçao do usuario
                    if (usuarios.FirstOrDefault(a => a.Id == usuario.Id) == null)
                    {
                        usuario.Departamentos = new List<Departamento>();
                        usuario.EnderecosEntrega = new List<EnderecoEntrega>();
                        usuario.Contato = contato;
                        usuarios.Add(usuario);
                    }
                    else
                    {
                        usuario = usuarios.FirstOrDefault(a => a.Id == usuario.Id);
                    }

                    // verificaçao do endereco de entrega
                    if(usuario.EnderecosEntrega.FirstOrDefault(a => a.Id == enderecoEntrega.Id) == null)
                    {
                        usuario.EnderecosEntrega.Add(enderecoEntrega);
                    }

                    // verificaçao do departamento
                    if(usuario.Departamentos.FirstOrDefault(a => a.Id == departamento.Id) == null)
                    {
                        usuario.Departamentos.Add(departamento);
                    }


                    return usuario;

                });

            return usuarios;
        }

        public Usuario GetUsuario(int id)
        {
            List<Usuario> usuarios = new();

            string sql = @"SELECT U.*, C.*, EE.*, D.* FROM Usuarios as U 
                                                      LEFT JOIN Contatos as C ON C.UsuarioId = U.Id 
                                                      LEFT JOIN EnderecosEntrega as EE ON EE.UsuarioId = U.Id 
                                                      LEFT JOIN UsuariosDepartamentos as UD ON UD.UsuarioId = U.Id 
                                                      LEFT JOIN Departamentos as D ON UD.DepartamentoId = D.Id WHERE U.Id = @Id";

            var result = _connection.Query<Usuario, Contato, EnderecoEntrega, Departamento, Usuario>(sql,
                (usuario, contato, enderecoEntrega, departamento) => 
                {
                    if (usuarios.FirstOrDefault(a => a.Id == usuario.Id) == null)
                    {
                        usuario.Departamentos = new List<Departamento>();
                        usuario.EnderecosEntrega = new List<EnderecoEntrega>();
                        usuario.Contato = contato;
                        usuarios.Add(usuario);
                    }
                    else
                    {
                        usuario = usuarios.FirstOrDefault(a => a.Id == usuario.Id);
                    }

                    // verificaçao do endereco de entrega
                    if (usuario.EnderecosEntrega.FirstOrDefault(a => a.Id == enderecoEntrega.Id) == null)
                    {
                        usuario.EnderecosEntrega.Add(enderecoEntrega);
                    }

                    // verificaçao do departamento
                    if (usuario.Departamentos.FirstOrDefault(a => a.Id == departamento.Id) == null)
                    {
                        usuario.Departamentos.Add(departamento);
                    }

                    return usuario;
                },
                new { Id = id }); // SingleOrDefault pega apenas um unico registro

            return result.FirstOrDefault();
        }

        public void InsertUsuario(Usuario usuario)
        {
            _connection.Open();
            var transaction = _connection.BeginTransaction();

            try
            {
                string sql = @"INSERT INTO Usuarios (Nome, Email, Sexo, RG, CPF, NomeMae, SituacaoCadastro, DataCadastro) 
                                             VALUES (@Nome, @Email, @Sexo, @RG, @CPF, @NomeMae, @SituacaoCadastro, @DataCadastro); 
                                             SELECT CAST(SCOPE_IDENTITY() AS INT);";
                usuario.Id = _connection.Query<int>(sql, usuario, transaction).Single();

                if (usuario.Contato != null)
                {
                    usuario.Contato.UsuarioId = usuario.Id;
                    string sqlContato = "INSERT INTO Contatos (UsuarioId, Telefone, Celular) " +
                        "                           VALUES (@UsuarioId, @Telefone, @Celular); SELECT CAST(SCOPE_IDENTITY() AS INT);";
                    usuario.Contato.Id = _connection.Query<int>(sqlContato, usuario.Contato, transaction).Single();
                }

                if(usuario.EnderecosEntrega != null && usuario.EnderecosEntrega.Count > 0)
                {
                    foreach(var enderecoEntrega in usuario.EnderecosEntrega)
                    {
                        enderecoEntrega.UsuarioId = usuario.Id;
                        string sqlEndereco = @"INSERT INTO EnderecosEntrega (UsuarioId, NomeEndereco, CEP, Estado, Cidade, Bairro, 
                                                          Endereco, Numero, Complemento) VALUES 
                                                          (@UsuarioId, @NomeEndereco, @CEP, @Estado, @Cidade, @Bairro, @Endereco, 
                                                           @Numero, @Complemento); SELECT CAST(SCOPE_IDENTITY() AS INT);";
                        enderecoEntrega.Id = _connection.Query<int>(sqlEndereco, enderecoEntrega, transaction).Single();
                    }
                }

                if(usuario.Departamentos != null && usuario.Departamentos.Count > 0)
                {
                    foreach(var departamento in usuario.Departamentos)
                    {
                        string sqlUsuariosDepartamentos = "INSERT INTO UsuariosDepartamentos (UsuarioId, DepartamentoId) " +
                            "                                         VALUES (@UsuarioId, @DepartamentoId)";
                        _connection.Execute(sqlUsuariosDepartamentos, new { UsuarioId = usuario.Id, DepartamentoId = departamento.Id }, transaction);
                    }
                }

                transaction.Commit();
            }
            catch(Exception)
            {
                try
                {
                    transaction.Rollback();
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }    
            }
            finally
            {
                _connection.Close();
            }  
        }

        public void UpdateUsuario(Usuario usuario)
        {
            _connection.Open();
            var transaction = _connection.BeginTransaction();
            try
            {
                string sql = "UPDATE Usuarios SET Nome = @Nome, Email = @Email, Sexo = @Sexo, RG = @RG, CPF = @CPF, NomeMae = @NomeMae, SituacaoCadastro = @SituacaoCadastro, DataCadastro = @DataCadastro WHERE Id = @Id";
                _connection.Execute(sql, usuario, transaction);

                if(usuario.Contato != null)
                {
                    string sqlContato = "UPDATE Contatos SET UsuarioId = @UsuarioId, Telefone = @Telefone, Celular = @Celular WHERE Id = @Id";
                    _connection.Execute(sqlContato, usuario.Contato, transaction);
                }

                string sqlDeletarEnderecosEntrega = "DELETE FROM EnderecosEntrega WHERE UsuarioId = @Id";
                _connection.Execute(sqlDeletarEnderecosEntrega, usuario, transaction);

                if (usuario.EnderecosEntrega != null && usuario.EnderecosEntrega.Count > 0)
                {
                    foreach (var enderecoEntrega in usuario.EnderecosEntrega)
                    {
                        enderecoEntrega.UsuarioId = usuario.Id;
                        string sqlEndereco = "INSERT INTO EnderecosEntrega (UsuarioId, NomeEndereco, CEP, Estado, Cidade, Bairro, Endereco, Numero, Complemento) VALUES (@UsuarioId, @NomeEndereco, @CEP, @Estado, @Cidade, @Bairro, @Endereco, @Numero, @Complemento); SELECT CAST(SCOPE_IDENTITY() AS INT);";
                        enderecoEntrega.Id = _connection.Query<int>(sqlEndereco, enderecoEntrega, transaction).Single();
                    }
                }

                string sqlDeletarUsuariosDepartamentos = "DELETE FROM UsuariosDepartamentos WHERE UsuarioId = @Id";
                _connection.Execute(sqlDeletarUsuariosDepartamentos, usuario, transaction);

                if(usuario.Departamentos != null && usuario.Departamentos.Count > 0)
                {
                    foreach(var departamento in usuario.Departamentos)
                    {
                        string sqlUsuariosDepartamentos = "INSERT INTO UsuariosDepartamentos (UsuarioId, DepartamentoId) VALUES (@UsuarioId, @DepartamentoId)";
                        _connection.Execute(sqlUsuariosDepartamentos, new { UsuarioId = usuario.Id, DepartamentoId = departamento.Id }, transaction);
                    }
                }

                transaction.Commit();
            }
            catch(Exception)
            {
                try
                {
                    transaction.Rollback();
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            finally
            {
                _connection.Close();
            }

            
        }

        public void DeleteUsuario(int id)
        {

            _connection.Execute("DELETE FROM Usuarios WHERE Id = @Id", new { Id = id });
        }
    }
}
