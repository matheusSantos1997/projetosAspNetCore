using MP.ApiDotnet6.Application.Dtos;
using MP.ApiDotNet6.Domain.FiltersDb;
using MP.ApiDotNet6.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotnet6.Application.Services.Interfaces
{
    public interface IPersonService
    {
        Task<ResultService<PersonDto>> CreateAsync(PersonDto personDTO);

        Task<ResultService<ICollection<PersonDto>>> GetAsync();

        Task<ResultService<PersonDto>> GetByIdAsync(int id);

        Task<ResultService> UpdateAsync(PersonDto personDTO);

        Task<ResultService> DeleteAsync(int id);

        Task<ResultService<PageBaseResponseDTO<PersonDto>>> GetPagedAsync(PersonFilterDb personFilterDb);
    }
}
