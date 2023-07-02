using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postagens.Repository.Repositories.DbQueries
{
    public class PostDbScript
    {
        public static string SelectAllPosts()
        {
            const string sql = @"SELECT * FROM posts as p LEFT JOIN imagens as i ON i.PostId = p.Id 
                                                          LEFT JOIN usuarios as u ON p.UsuarioId = u.Id";

            return sql;
        }

        public static string SelectPostById()
        {
            const string sql = @"SELECT * FROM posts as p LEFT JOIN imagens as i ON i.PostId = p.Id 
                                                          LEFT JOIN usuarios as u ON p.UsuarioId = u.Id WHERE p.Id = @Id";

            return sql;
        }
    }
}
