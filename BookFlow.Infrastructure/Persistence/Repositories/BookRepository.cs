using BookFlow.Core.Entities;
using BookFlow.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFlow.Infrastructure.Persistence.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookFlowDbContext _dbContext;
        public BookRepository(BookFlowDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> AddASync(Book book)
        {
            await _dbContext.Books.AddAsync(book);
            await _dbContext.SaveChangesAsync();

            return book.Id;
        }

        public async Task DeleteAsync(int id)
        {
            var book = await _dbContext.Books.SingleOrDefaultAsync(p => p.Id == id);

            if(book != null)
                _dbContext.Books.Remove(book);
        }

        public async Task<List<Book>> GetAllAsync()
        {
            return await _dbContext.Books.ToListAsync();
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            var book = await _dbContext.Books.SingleOrDefaultAsync(p => p.Id == id);

            return book;
        }
    }
}
