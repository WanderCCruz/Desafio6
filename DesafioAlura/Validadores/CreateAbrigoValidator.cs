using DesafioAlura.DTOs.Abrigo;
using DesafioAlura.Entidades;
using FluentValidation;

namespace DesafioAlura.Validadores
{
    public class CreateAbrigoValidator : AbstractValidator<CreateAbrigoDTO>    
    {
        public CreateAbrigoValidator()
        {
            RuleFor(nome => nome.Nome).NotEmpty().NotNull().WithMessage("Campo obrigatório");
            RuleFor(nome => nome.Nome).MaximumLength(150).MinimumLength(10).WithMessage("Nome deve ter entre 10 e 150 caracteres");
        }
    }
}
