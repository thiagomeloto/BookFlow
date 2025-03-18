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
        public int IdUser { get; set; }
        public int IdBook { get; set; }
        public DateTime DateBorrowing { get; set; }
    }
}
