namespace uploadApi.Interfaces
{
    public interface IUploadRepository
    {
        void Add<T>(T entity) where T : class;

        bool SaveChanges(); // salva as alteracoes
    }
}