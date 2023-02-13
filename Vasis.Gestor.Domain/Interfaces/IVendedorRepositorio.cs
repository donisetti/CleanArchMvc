using Vasis.Gestor.Domain.Entidades;

namespace Vasis.Gestor.Domain.Interfaces;


public interface IVendedorRepositorio
{
    Task<IEnumerable<Vendedor>> ObterTodosAsync();
    Task<Vendedor> ObterIdAsync(Guid id);

    Task<Vendedor> CriarAsync(Vendedor vendedor);
    Task<Vendedor> AtualizarAsync(Vendedor vendedor);
    Task<Vendedor> ExcluirAsync(Vendedor vendedor);
}
