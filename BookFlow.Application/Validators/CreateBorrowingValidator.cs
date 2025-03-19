using BookFlow.Application.Commands.CreateBorrowing;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFlow.Application.Validators
{
    public class CreateBorrowingValidator : AbstractValidator<CreateBorrowingCommand>
    {
        public CreateBorrowingValidator()
        {
            RuleFor(b => b.DateBorrowing)
                .NotEmpty()
                    .WithMessage("Data não pode ser vazia")
                .Must(b => b > DateTime.Now.Date)
                    .WithMessage("Data de emprestimo não pode ser anterior a data de hoje");
        }
    }
}
