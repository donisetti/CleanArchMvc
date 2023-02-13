﻿using Vasis.Gestor.Application.Products.Queries;
using Vasis.Gestor.Domain.Entities;
using Vasis.Gestor.Domain.Interfaces;
using MediatR;

namespace Vasis.Gestor.Application.Products.Handlers;

public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
{
    private readonly IProductRepository _productRepository;

    public GetProductsQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<IEnumerable<Product>> Handle(GetProductsQuery request,
        CancellationToken cancellationToken)
    {
        return await _productRepository.GetProductsAsync();
    }
}