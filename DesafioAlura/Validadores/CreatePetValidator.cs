using DesafioAlura.DTOs.Pet;
using DesafioAlura.Entidades;
using DesafioAlura.Enums;
using FluentValidation;

namespace DesafioAlura.Validadores
{
    public class CreatePetValidator : AbstractValidator<CreatePetDTO>
    {
        public CreatePetValidator()
        {
            RuleFor(nome => nome.Nome).NotEmpty().NotNull().WithMessage("Campo obrigatório");
            RuleFor(nome => nome.Nome).MaximumLength(150).MinimumLength(10).WithMessage("Nome deve ter entre 10 e 150 caracteres");
            RuleFor(especie => especie.Especie).IsInEnum();
            RuleFor(tamanho => tamanho.Tamanho).IsInEnum();
            RuleFor(personalidade => personalidade.Personalidade).NotNull().WithMessage("Campo obrigatório");
            RuleFor(personalidade => personalidade.Personalidade).MaximumLength(150).MinimumLength(5)
                .WithMessage("Personalidade deve ter entre 5 e 150 caracteres");
            RuleFor(cidade => cidade.Cidade).NotEmpty().WithMessage("Campo obrigatório");
            RuleFor(Cidade => Cidade.Cidade).MaximumLength(150).MinimumLength(4).WithMessage("Cidade deve ter entre 4 e 100 caracteres");
            RuleFor(estado => estado.Estado).NotEmpty().WithMessage("Campo obrigatório");
            RuleFor(estado => estado.Estado).MaximumLength(150).MinimumLength(4).WithMessage("Estado deve ter entre 4 e 100 caracteres");
        }
    }
}
