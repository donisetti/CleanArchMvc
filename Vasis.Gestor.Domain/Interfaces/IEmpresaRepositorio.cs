using Vasis.Gestor.Domain.Entidades;

namespace Vasis.Gestor.Domain.Interfaces;


public interface IEmpresaRepositorio
{
    Task<IEnumerable<Empresa>> ObterTodosAsync();
    Task<Empresa> ObterIdAsync(Guid id);

    Task<Empresa> CriarAsync(Empresa empresa);
    Task<Empresa> AtualizarAsync(Empresa empresa);
    Task<Empresa> ExcluirAsync(Empresa empresa);

}
