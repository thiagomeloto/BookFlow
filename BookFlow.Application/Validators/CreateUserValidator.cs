using BookFlow.Application.Commands.CreateUser;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFlow.Application.Validators
{
    public class CreateUserValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserValidator()
        {
            RuleFor(u => u.Name)
                .NotEmpty()
                    .WithMessage("Nome não deve ser vazio")
                .MaximumLength(50)
                    .WithMessage("Nome não deve ultrapassar 50 caracteres");

            RuleFor(u => u.Email)
                .EmailAddress()
                    .WithMessage("E-mail inválido");
        }
    }
}
