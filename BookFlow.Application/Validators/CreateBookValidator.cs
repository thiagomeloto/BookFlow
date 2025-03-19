using BookFlow.Application.Commands.CreateBook;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFlow.Application.Validators
{
    public class CreateBookValidator : AbstractValidator<CreateBookCommand>
    {
        public CreateBookValidator()
        {
            RuleFor(p => p.Title)
                .NotEmpty()
                    .WithMessage("Título não pode ser vazio.")
                .MaximumLength(200)
                    .WithMessage("O tamanho do título é muito grande. Precisa ter menos de 200 caracteres");

            RuleFor(p => p.Author)
                .NotEmpty()
                    .WithMessage("Autor não pode ser vazio.")
                .MaximumLength(150)
                    .WithMessage("O tamanho nome do autor é muito grande. Precisa ter menos de 150 caracteres");

            RuleFor(p => p.YearPublication)
                .NotEmpty()
                    .WithMessage("Ano de publicação não pode ser vazio")
                .Must(year => year > DateTime.Now.Year - 50)
                .WithMessage("Livro não pode ser mais velho que 50 anos");
        }
    }
}
