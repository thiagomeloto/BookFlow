using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFlow.Application.Commands.CreateBorrowing
{
    public class CreateBorrowingCommandHandler : IRequestHandler<CreateBorrowingCommand, int>
    {
        public Task<int> Handle(CreateBorrowingCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
