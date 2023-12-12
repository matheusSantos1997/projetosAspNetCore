using AutoMapper;
using MP.ApiDotnet6.Application.Dtos;
using MP.ApiDotNet6.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotnet6.Application.Mappings
{
    public class DtoToDomainMapping : Profile
    {
        public DtoToDomainMapping()
        {
            CreateMap<PersonDto, Person>();

            CreateMap<ProductDto, Product>();
        }
    }
}
