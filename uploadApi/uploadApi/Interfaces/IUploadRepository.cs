using System.Collections.Generic;
using uploadApi.Models;

namespace uploadApi.Interfaces
{
    public interface IUploadRepository
    {
        void Add<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;

        void Update<T>(T entity) where T : class;

        bool SaveChanges(); // salva as alteracoes

        List<Arquivos> GetAllArquivos();

        Arquivos GetByIdArquivo(int id);
    }
}