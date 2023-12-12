using AutoMapper;
using MP.ApiDotnet6.Application.Dtos;
using MP.ApiDotnet6.Application.Dtos.Validations;
using MP.ApiDotnet6.Application.Services.Interfaces;
using MP.ApiDotNet6.Domain.FiltersDb;
using MP.ApiDotNet6.Domain.Models;
using MP.ApiDotNet6.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotnet6.Application.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        private readonly IMapper _mapper;

        public PersonService(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public async Task<ResultService<PersonDto>> CreateAsync(PersonDto personDTO)
        {
            if (personDTO == null) return ResultService.Fail<PersonDto>("Objeto deve ser informado!");

            var result = new PersonDTOValidator().Validate(personDTO);

            if(!result.IsValid)
            {
                return ResultService.RequestError<PersonDto>("problemas de validade", result);
            }

            var person = _mapper.Map<Person>(personDTO);

            var data = await _personRepository.CreateAsync(person);

            return ResultService.Ok<PersonDto>(_mapper.Map<PersonDto>(data));
        }

        public async Task<ResultService> DeleteAsync(int id)
        {
            var person = await _personRepository.GetByIdAsync(id);

            if (person == null) return ResultService.Fail("Pessoa Não encontrada!");

            await _personRepository.DeleteAsync(person);

            return ResultService.Ok($"Pessoa do id {id} foi deletada com sucesso!");
        }

        public async Task<ResultService<PageBaseResponseDTO<PersonDto>>> GetPagedAsync(PersonFilterDb personFilterDb)
        {
            var peoplePaged = await _personRepository.GetPagedAsync(personFilterDb);
            var result = new PageBaseResponseDTO<PersonDto>(peoplePaged.TotalRegisters, _mapper.Map<List<PersonDto>>(peoplePaged.Data));

            return ResultService.Ok(result);
        }

        public async Task<ResultService<ICollection<PersonDto>>> GetAsync()
        {
            var peoples = await _personRepository.GetPeopleAsync();

            return ResultService.Ok<ICollection<PersonDto>>(_mapper.Map<ICollection<PersonDto>>(peoples));
        }

        public async Task<ResultService<PersonDto>> GetByIdAsync(int id)
        {
            var person = await _personRepository.GetByIdAsync(id);

            if (person == null) return ResultService.Fail<PersonDto>("Pessoa não encontrada!");

            return ResultService.Ok<PersonDto>(_mapper.Map<PersonDto>(person));
        }

        public async Task<ResultService> UpdateAsync(PersonDto personDTO)
        {
            if (personDTO == null) return ResultService.Fail("Objeto deve ser informado!");

            var validation = new PersonDTOValidator().Validate(personDTO);

            if (!validation.IsValid) return ResultService.RequestError("Problemas com a validação dos campos", validation);

            var person = await _personRepository.GetByIdAsync(personDTO.Id);

            if (person == null) return ResultService.Fail("Pessoa não encontrada");

           // var person = _mapper.Map<Person>(personDTO); // inserçao quando cria um novo objeto mapeado
           person = _mapper.Map<PersonDto, Person>(personDTO, person);

           await _personRepository.EditAsync(person);

            return ResultService.Ok("Pessoa editada com sucesso!");


        }
    }
}
