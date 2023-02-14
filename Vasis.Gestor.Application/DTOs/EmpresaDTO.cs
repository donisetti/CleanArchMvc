using System.ComponentModel.DataAnnotations;

namespace Vasis.Gestor.Application.DTOs;

public class EmpresaDTO
{
    public Guid Id { get; set; }

    [Required(ErrorMessage = "O Nome é Obrigatório")]
    [MinLength(3)]
    [MaxLength(100)]
    public string Nome { get; set; } = null!;
}
