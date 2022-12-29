using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace cursoDapper.ConnectionDB
{
    public static class ConnDB
    {
        public static IDbConnection GetConnection()
        {
            try
            {
                // string conn = "Password=root; Persist Security Info=true;User ID=sa;Initial Catalog=eCommerce;Data Source=DESKTOP-OJRVGVQ\\SQLEXPRESS";
                return new SqlConnection(Base.STRINGCONEXAO);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }   
        
    }
}
