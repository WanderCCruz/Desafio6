using DesafioAlura.DTOs.Usuario;
using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace DesafioAlura.Validadores
{
    public class CreateUsuarioValidator : AbstractValidator<CreateUsuarioDTO>
    {
        public CreateUsuarioValidator()
        {
            RuleFor(nome => nome.Nome).NotEmpty().NotNull().WithMessage("Campo obrigatório");
            RuleFor(nome => nome.Nome).MaximumLength(150).MinimumLength(10).WithMessage("O campo deve ter entre 10 e 150 caracteres");
            RuleFor(senha => senha.Senha).NotEmpty().NotNull().WithMessage("Campo obrigatório");
            RuleFor(senha => senha.Senha).Matches("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])[0-9a-zA-Z$*&@#]{8,}$").
                WithMessage("A senha deve ter letras maiúsculas, minúsculas, numeros e conter pelo menos 8 digitos");
            RuleFor(senha => senha.Senha).MaximumLength(50).MinimumLength(6).WithMessage("O campo deve ter entre 6 e 50 caracteres");
            RuleFor(email => email.Email).NotEmpty().NotNull().WithMessage("Campo obrigatório").EmailAddress();
            RuleFor(email => email.Email).EmailAddress().WithMessage("Email incorreto");
            RuleFor(email => email.Email).MaximumLength(150).MinimumLength(10).WithMessage("O campo deve ter entre 6 e 50 caracteres");
            RuleFor(sobre => sobre.Sobre).NotEmpty().NotNull().WithMessage("Campo obrigatório");
            RuleFor(sobre => sobre.Sobre).MaximumLength(150).MinimumLength(10).WithMessage("O campo deve ter entre 6 e 50 caracteres");

        }
    }
}
