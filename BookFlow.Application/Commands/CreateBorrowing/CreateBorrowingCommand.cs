using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFlow.Application.Commands.CreateBorrowing
{
    public class CreateBorrowingCommand : IRequest<int>
    {
        public int Id { get; private set; }
        public int IdUser { get; private set; }
        public int IdBook { get; private set; }
        public DateTime DateBorrowing { get; private set; }
    }
}
