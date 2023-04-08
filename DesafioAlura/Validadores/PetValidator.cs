using DesafioAlura.DTOs.Pet;
using DesafioAlura.Entidades;
using FluentValidation;

namespace DesafioAlura.Validadores
{
    public class PetValidator : AbstractValidator<CreatePetDTO>
    {
        public PetValidator()
        {
            RuleFor(nome => nome.Nome).NotEmpty().NotNull().WithMessage("Campo obrigatório");
            RuleFor(nome => nome.Nome).MaximumLength(150).MinimumLength(10).WithMessage("Nome deve ter entre 10 e 150 caracteres");
            RuleFor(especie => especie.Especie).NotNull().NotEmpty().WithMessage("Campo obrigatório");
            RuleFor(tamanho => tamanho.Tamanho).NotNull().NotEmpty().WithMessage("Campo obrigatório");
            RuleFor(personalidade => personalidade.Personalidade).NotNull().WithMessage("Campo obrigatório");
            RuleFor(personalidade => personalidade.Personalidade).MaximumLength(150).MinimumLength(10)
                .WithMessage("Nome deve ter entre 10 e 150 caracteres");
            RuleFor(cidade => cidade.Cidade).NotEmpty().WithMessage("Campo obrigatório");
            RuleFor(estado => estado.Estado).MaximumLength(150).MinimumLength(10).WithMessage("Nome deve ter entre 10 e 150 caracteres");

        }
    }
}
