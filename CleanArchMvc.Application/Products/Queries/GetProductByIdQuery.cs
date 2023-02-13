﻿using Vasis.Gestor.Domain.Entities;
using MediatR;

namespace Vasis.Gestor.Application.Products.Queries;

public class GetProductByIdQuery : IRequest<Product>
{
    public int Id { get; set; }
    public GetProductByIdQuery(int id)
    {
        Id = id;
    }
}
