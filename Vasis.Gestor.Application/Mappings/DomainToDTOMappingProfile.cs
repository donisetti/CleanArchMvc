using AutoMapper;
using Vasis.Gestor.Application.DTOs;
using Vasis.Gestor.Domain.Entities;

namespace Vasis.Gestor.Application.Mappings;

public class DomainToDTOMappingProfile : Profile
{
    public DomainToDTOMappingProfile()
    {
        CreateMap<Category, CategoryDTO>().ReverseMap();
        CreateMap<Product, ProductDTO>().ReverseMap();
    }
}
