using Vasis.Gestor.Application.Products.Queries;
using Vasis.Gestor.Domain.Entities;
using Vasis.Gestor.Domain.Interfaces;
using MediatR;

namespace Vasis.Gestor.Application.Products.Handlers;

public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
{
    private readonly IProductRepository _productRepository;
    public GetProductByIdQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<Product> Handle(GetProductByIdQuery request,
         CancellationToken cancellationToken)
    {
        return await _productRepository.GetByIdAsync(request.Id);
    }
}
