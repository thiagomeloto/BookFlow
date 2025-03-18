using BookFlow.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFlow.Application.Queries.GetBorrowingById
{
    public class GetBorrowingByIdQuery : IRequest<Borrowing>
    {
        public int Id { get; set; }
    }
}
