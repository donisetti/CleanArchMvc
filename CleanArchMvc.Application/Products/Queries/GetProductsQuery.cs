using Vasis.Gestor.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Vasis.Gestor.Application.Products.Queries;

public class GetProductsQuery : IRequest<IEnumerable<Product>>
{
}
