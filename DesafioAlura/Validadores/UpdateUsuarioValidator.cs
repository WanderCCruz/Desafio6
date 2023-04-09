using DesafioAlura.DTOs.Usuario;
using FluentValidation;

namespace DesafioAlura.Validadores
{
    public class UpdateUsuarioValidator : AbstractValidator<UpdateUsuarioDTO>
    {
        public UpdateUsuarioValidator()
        {
            RuleFor(nome => nome.Nome).NotEmpty().NotNull().WithMessage("Campo obrigatório");
            RuleFor(nome => nome.Nome).MaximumLength(150).MinimumLength(10).WithMessage("O campo deve ter entre 10 e 150 caracteres");
            RuleFor(email => email.Email).NotEmpty().NotNull().WithMessage("Campo obrigatório");
            RuleFor(email => email.Email).MaximumLength(150).MinimumLength(10).WithMessage("O campo deve ter entre 6 e 50 caracteres");
            RuleFor(sobre => sobre.Sobre).NotEmpty().NotNull().WithMessage("Campo obrigatório");
            RuleFor(sobre => sobre.Sobre).MaximumLength(150).MinimumLength(10).WithMessage("O campo deve ter entre 6 e 50 caracteres");
        }
    }
}
