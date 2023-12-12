using Microsoft.EntityFrameworkCore;
using MP.ApiDotNet6.Domain.FiltersDb;
using MP.ApiDotNet6.Domain.Models;
using MP.ApiDotNet6.Domain.Repositories;
using MP.ApiDotNet6.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Infra.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ApplicationDbContext _db;

        public PersonRepository(ApplicationDbContext db)
        {
            _db = db;   
        }

        public async Task<Person> CreateAsync(Person person)
        {
            _db.Add(person);
            await _db.SaveChangesAsync();
            return person;
        }

        public async Task DeleteAsync(Person person)
        {
            _db.Remove(person);
            await _db.SaveChangesAsync();
        }

        public async Task EditAsync(Person person)
        {
            _db.Update(person);
            await _db.SaveChangesAsync();
        }

        public async Task<Person> GetByIdAsync(int id)
        {
            var query = await _db.People.FirstOrDefaultAsync(p => p.Id == id);
            return query!;

        }

        public async Task<int> GetIdByDocumentAsync(string document)
        {
            return (await _db.People.FirstOrDefaultAsync(x => x.Document == document))?.Id ?? 0;
        }

        public async Task<PageBaseResponse<Person>> GetPagedAsync(PersonFilterDb request)
        {
            var people = _db.People.AsQueryable();

            if(!string.IsNullOrEmpty(request.Name))
                people = people.Where(x => x.Name.ToLower().Contains(request.Name.ToLower()));

            return await PagedBaseResponseHelper.GetResponseAsync<PageBaseResponse<Person>, Person>(people, request);
        }

        public async Task<ICollection<Person>> GetPeopleAsync()
        {
            var query = await _db.People.OrderBy(x => x.Id).ToListAsync();
            return query;
        }
    }
}
