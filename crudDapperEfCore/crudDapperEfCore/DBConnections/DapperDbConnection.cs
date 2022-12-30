using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace crudDapperEfCore.DBConnections
{
    public static class DapperDbConnection
    {
        public static IDbConnection GetConnetion()
        {
            try
            {
                string conn = ConnectionString.StringConexao;

                return new SqlConnection(conn);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
