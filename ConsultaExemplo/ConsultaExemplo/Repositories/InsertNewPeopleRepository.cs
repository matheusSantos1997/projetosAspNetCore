using ConsultaExemplo.Data;
using ConsultaExemplo.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsultaExemplo.Repositories
{
    public class InsertNewPeopleRepository : IInsertNewPeopleRepository
    {
        private readonly DataContext _context;

        public InsertNewPeopleRepository(DataContext context)
        {
            _context = context;
        }

        public void AddPeople(People people)
        {
            _context.Add(people);
            _context.SaveChanges();
        }
    }
}
