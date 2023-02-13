using Vasis.Gestor.Domain.Validation;

namespace Vasis.Gestor.Domain.Entidades;


public class Vendedor : Pessoa
{


    public Vendedor(string nome)
    {
        ValidateDomain(nome);
    }



    private void ValidateDomain(string nome)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(nome),
            "Nome inválido. O nome é obrigatório");

        DomainExceptionValidation.When(nome.Length < 3,
            "Nome inválido, muito curto, mínimo 3 caracteres");


    }
}