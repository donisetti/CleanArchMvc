using AutoMapper;
using Vasis.Gestor.Application.DTOs;
using Vasis.Gestor.Application.Products.Commands;

namespace Vasis.Gestor.Application.Mappings;

public class DTOToCommandMappingProfile : Profile
{
    public DTOToCommandMappingProfile()
    {
        CreateMap<ProductDTO, ProductCreateCommand>();
        CreateMap<ProductDTO, ProductUpdateCommand>();
    }
}
