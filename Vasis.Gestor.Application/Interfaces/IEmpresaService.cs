using Vasis.Gestor.Application.DTOs;

namespace Vasis.Gestor.Application.Interfaces;

public interface IEmpresaService
{

    Task<IEnumerable<EmpresaDTO>> ObterTodos();
    Task<EmpresaDTO> ObterPorId(int? id);
    Task Incluir(EmpresaDTO categoryDto);
    Task Alterar(EmpresaDTO categoryDto);
    Task Excluir(int? id);

}
