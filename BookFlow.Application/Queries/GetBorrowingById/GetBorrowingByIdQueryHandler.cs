using BookFlow.Core.Entities;
using BookFlow.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFlow.Application.Queries.GetBorrowingById
{
    public class GetBorrowingByIdQueryHandler : IRequestHandler<GetBorrowingByIdQuery, Borrowing>
    {
        private readonly IBorrowingRepository _borrowingRepository;

        public GetBorrowingByIdQueryHandler(IBorrowingRepository borrowingRepository)
        {
            _borrowingRepository = borrowingRepository;
        }
        public async Task<Borrowing> Handle(GetBorrowingByIdQuery request, CancellationToken cancellationToken)
        {
            return await _borrowingRepository.GetByIdAsync(request.Id);
        }
    }
}
