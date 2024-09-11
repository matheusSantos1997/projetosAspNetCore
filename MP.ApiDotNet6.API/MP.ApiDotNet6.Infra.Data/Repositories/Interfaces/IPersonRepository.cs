using MP.ApiDotNet6.Domain.Models;
using MP.ApiDotNet6.Infra.Data.FiltersDb;
using MP.ApiDotNet6.Infra.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Infra.Data.Repositories.Interfaces
{
    public interface IPersonRepository
    {
        Task<Person> GetByIdAsync(int id);

        Task<ICollection<Person>> GetPeopleAsync();

        Task<Person> CreateAsync(Person person);

        Task EditAsync(Person person);

        Task DeleteAsync(Person person);

        Task<int> GetIdByDocumentAsync(string document);

        Task<PageBaseResponse<Person>> GetPagedAsync(PersonFilterDb request);
    }
}
