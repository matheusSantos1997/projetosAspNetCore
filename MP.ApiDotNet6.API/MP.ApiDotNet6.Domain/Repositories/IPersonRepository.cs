using MP.ApiDotNet6.Domain.FiltersDb;
using MP.ApiDotNet6.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Domain.Repositories
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
