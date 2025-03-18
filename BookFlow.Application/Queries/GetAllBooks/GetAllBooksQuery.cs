using BookFlow.Application.ViewModels;
using BookFlow.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFlow.Application.Queries.GetAllBooks
{
    public class GetAllBooksQuery : IRequest<List<Book>>
    {
        
    }
}
