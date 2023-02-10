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
            string sql = @"SELECT * FROM Clientes as c LEFT JOIN Produtos as p ON p.ClienteId = c.Id";

            return sql;
        }

        public static string SelectClientePeloId()
        {
            string sql = @"SELECT * FROM Clientes as c LEFT JOIN Produtos as p ON p.ClienteId = c.Id WHERE c.Id = @Id";

            return sql;
        }

        public static string FiltrarClientePorNome()
        {
            string sql = @"SELECT * FROM Clientes as c LEFT JOIN Produtos as p ON p.ClienteId = c.Id WHERE c.NomeCliente LIKE @NomeCliente";

            return sql;
        }
    }
}
