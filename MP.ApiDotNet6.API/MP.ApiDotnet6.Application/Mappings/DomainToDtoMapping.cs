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
    public class DomainToDtoMapping : Profile
    {
        public DomainToDtoMapping() 
        {
            // CreateMap<Person, PersonDto>().ReverseMap();
            CreateMap<Person, PersonDto>();

            CreateMap<Product, ProductDto>();

            CreateMap<Purchase, PurchaseDetailDto>()
                .ForMember(x => x.Person, opt => opt.Ignore()) // ignora o objeto Person para conseguir acessar a propriedade Name
                .ForMember(x => x.Product, opt => opt.Ignore()) // ignora o objeto Product para conseguir acessar a propriedade Name
                .ConstructUsing((model, context) =>
                {
                    var dto = new PurchaseDetailDto
                    {
                        Product = model.Product.Name,
                        Id = model.Id,
                        Date = model.Date,
                        Person = model.Person.Name
                    };

                    return dto;
                });
        }
    }
}
