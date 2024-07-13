using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudDapperEfCore.Repositories.DbScripts
{
    public class ClienteQueriesString
    {
        public static string SelectAllClientes()
        {
            const string sql = @"SELECT * FROM Clientes as c LEFT JOIN 
                                               Produtos as p ON p.ClienteId = c.Id";

            return sql;
        }

        public static Dictionary<string, object> SelectClientePeloId(long id)
        {
            const string sql = @"SELECT * FROM Clientes as c LEFT JOIN 
                                               Produtos as p ON p.ClienteId = c.Id WHERE c.Id = @Id";

            return new Dictionary<string, object> { { sql, new { Id = id } } };
         
        }

        public static Dictionary<string, object> FiltrarClientePorNome(string nomeCliente)
        {
            const string sql = @"SELECT c.*, p.* FROM Clientes AS c LEFT JOIN 
                                                      Produtos AS p ON p.ClienteId = c.Id 
                                                      WHERE c.NomeCliente COLLATE Latin1_General_CI_AI LIKE @NomeCliente";

            return new Dictionary<string, object> { { sql, new { NomeCliente = nomeCliente + "%"}} };
        }
    }
}
