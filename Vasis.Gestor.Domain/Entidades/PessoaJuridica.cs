using Vasis.Gestor.Domain.Interfaces;

namespace Vasis.Gestor.Domain.Entidades;

public abstract class PessoaJuridica : IEntidade
{

    public Guid Id { get; set; }
    public string Nome { get; set; } = null!;
    public string? UsuarioCriacaoId { get; set; }

}