using DesafioAlura.DTOs.Abrigo;
using FluentValidation;

namespace DesafioAlura.Validadores
{
    public class UpdateAbrigoValidator : AbstractValidator<UpdateAbrigoDTO>
    {
        public UpdateAbrigoValidator()
        {
            RuleFor(nome => nome.Nome).NotEmpty().NotNull().WithMessage("Campo obrigatório");
            RuleFor(nome => nome.Nome).MaximumLength(150).MinimumLength(10).WithMessage("Nome deve ter entre 10 e 150 caracteres");
        }
    }
}
