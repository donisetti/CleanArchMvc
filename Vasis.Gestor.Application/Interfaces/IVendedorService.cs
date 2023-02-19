using Vasis.Gestor.Application.DTOs;

namespace Vasis.Gestor.Application.Interfaces;

public interface IVendedorService
{

    Task<IEnumerable<VendedorDTO>> ObterTodos();
    Task<VendedorDTO> ObterPorId(int? id);
    Task Incluir(VendedorDTO categoryDto);
    Task Alterar(VendedorDTO categoryDto);
    Task Excluir(int? id);
}
