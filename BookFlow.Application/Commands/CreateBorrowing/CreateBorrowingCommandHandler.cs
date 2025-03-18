using BookFlow.Core.Entities;
using BookFlow.Core.Repositories;
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
        private readonly IBorrowingRepository _borrowingRepository;

        public CreateBorrowingCommandHandler(IBorrowingRepository borrowingRepository)
        {
            _borrowingRepository = borrowingRepository;
        }
        public async Task<int> Handle(CreateBorrowingCommand request, CancellationToken cancellationToken)
        {
            var borrowing = new Borrowing(request.IdUser, request.IdBook, request.DateBorrowing);

            return await _borrowingRepository.AddASync(borrowing);
        }
    }
}
