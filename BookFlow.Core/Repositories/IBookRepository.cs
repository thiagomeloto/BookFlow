using BookFlow.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFlow.Core.Repositories
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAllAsync();
        Task<Book> GetBookByIdAsync(int id);
        Task<int> AddASync(Book book);
        Task DeleteAsync(int id);
    }
}
