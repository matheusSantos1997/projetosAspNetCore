namespace crudDapperEfCore.API.Services.Interfaces
{
    public interface IExcelExportService
    {
        Task<byte[]> ExportToExcelAsync<T>(List<T> data, string sheetName, Dictionary<string, string> propertyPathToAlias);

        Task<string> ExportToExcelBase64Async<T>(List<T> data, string sheetName, Dictionary<string, string> propertyPathToAlias);
    }
}