using ConsultaExemplo.Data;
using ConsultaExemplo.Models;
using ConsultaExemplo.PaginationItems;
using Dapper;
using System.Data;

namespace ConsultaExemplo.Repositories
{
    public class PeopleRepository : IPeopleRepository
    {

        private readonly IDbConnection _connection;

        public PeopleRepository()
        {
            _connection = DataContext.GetConnetion(); 
        }

        public PeoplePaginationResult AllPeoples(Pagination pagination)
        {
            var result = new PeoplePaginationResult()
            {
                Peoples = new List<People>(),
                TotalCount = null
            };
           // result.Peoples = new List<People>();

            try
            {
                _connection.Open();

                // Fetch paginated result for People
                string query = @"SELECT p.IdPeople, p.Name, p.Email
                         FROM Peoples p 
                         ORDER BY p.IdPeople
                         LIMIT @PageSize OFFSET @Offset;";

                result.Peoples = _connection.Query<People>(query, new { PageSize = pagination.PageSize, Offset = (pagination.PageNumber - 1) * pagination.PageSize }).ToList();

                // Count the total number of distinct people
                string countQuery = @"SELECT COUNT(DISTINCT IdPeople)
                              FROM Peoples;";

                result.TotalCount = _connection.ExecuteScalar<int>(countQuery);

                // Fetch cars for each person
                string carsQuery = @"SELECT p.IdPeople, c.IdCar, c.Mark, c.Model, c.Price
                             FROM Peoples p 
                             LEFT JOIN Cars c ON p.IdPeople = c.PeopleId;";

                var cars = _connection.Query<People, Car, People>(carsQuery, (person, car) =>
                {
                    var existingPeople = result.Peoples.FirstOrDefault(x => x.IdPeople == person.IdPeople);

                    if (existingPeople != null)
                    {
                        if (existingPeople.Cars == null)
                        {
                            existingPeople.Cars = new List<Car>();
                        }

                        existingPeople.Cars.Add(car);
                    }

                    return person;
                }, splitOn: "IdPeople, IdCar");

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }
    }
}
