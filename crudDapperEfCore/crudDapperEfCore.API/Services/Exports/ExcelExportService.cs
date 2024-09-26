using System.Collections;
using crudDapperEfCore.API.Services.Interfaces;
using Newtonsoft.Json;
using OfficeOpenXml;

namespace crudDapperEfCore.API.Services.Exports
{
    public class ExcelExportService : IExcelExportService
    {
        public async Task<byte[]> ExportToExcelAsync<T>(List<T> data, string sheetName, Dictionary<string, string> propertyPathToAlias)
        {
            var projectedData = ProjectData(data, propertyPathToAlias);

            using(var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add(sheetName);
                var rowIndex = 1;
                var columIndex = 1;

                // Adiciona a linha de cabeçalhos com apelidos
                foreach (var alias in propertyPathToAlias.Values)
                {
                    worksheet.Cells[rowIndex, columIndex++].Value = alias;
                }

                //Adicionando as linhas de dados
                foreach (var item in projectedData)
                {
                    rowIndex++;
                    columIndex = 1;

                    foreach(var path in propertyPathToAlias.Keys)
                    {
                        var value = item[propertyPathToAlias[path]];
                        var cell = worksheet.Cells[rowIndex, columIndex++];

                        // Verifica se o valor é DateTime e aplica a formataçao desejada
                        if (value is DateTime dateTimeValue)
                        {
                            // faz a tratativa se caso alguma data de alguma tabela estiver nula
                            cell.Value = dateTimeValue != default(DateTime) ? dateTimeValue : null;
                            cell.Style.Numberformat.Format = "dd/MM/yyyy HH:mm:ss"; // Ajuste o formato conforme necessário
                        }
                        else
                        {
                            cell.Value = value;
                        }
                    }
                }

                var byteArray = package.GetAsByteArray();
                return await Task.FromResult(byteArray);
            }
        }

        public async Task<string> ExportToExcelBase64Async<T>(List<T> data, string sheetName, Dictionary<string, string> propertyPathToAlias)
        {
            var byteArray = await ExportToExcelAsync(data, sheetName, propertyPathToAlias);
            var base64String = Convert.ToBase64String(byteArray);
            return base64String;
        }

        private static IEnumerable<Dictionary<string, object>> ProjectData<T>(List<T> data, Dictionary<string, string> propertyPathToAlias)
        {
            foreach (var item in data)
            {
                var dictionary = new Dictionary<string, object>();
                foreach (var path in propertyPathToAlias.Keys)
                {
                    var value = GetNestedPropertyValue(item!, path);
                    dictionary[propertyPathToAlias[path]] = value;
                }

                yield return dictionary;
            }
        }

        private static object GetNestedPropertyValue(object obj, string propertyPath)
        {
            foreach (var part in propertyPath.Split('.'))
            {
                if (obj == null)
                {
                    return null!;
                }

                var type = obj.GetType();
                var property = type.GetProperty(part);
                if(property == null)
                {
                    return null!;
                }

                obj = property.GetValue(obj)!;

                // verifica se é uma coleçao e trata especificamente
                if (obj is IList iList)
                {
                    var list = new List<string>();
                    foreach (var element in iList)
                    {
                        var elementProperties = element.GetType().GetProperties();
                        var dict = new Dictionary<string, object>();

                        foreach (var prop in elementProperties)
                        {
                            var value = prop.GetValue(element);
                            if(value != null)
                            {
                                dict[prop.Name] = value!;
                            }
                        }

                        var json = JsonConvert.SerializeObject(dict, new JsonSerializerSettings
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                        });
                        list.Add(json);
                    }

                    return string.Join(" ; ", list);
                }
            }
            return obj;
        }
    }
}