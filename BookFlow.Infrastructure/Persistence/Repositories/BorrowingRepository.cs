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
    public class BorrowingRepository : IBorrowingRepository
    {
        private readonly BookFlowDbContext _dbContext;

        public BorrowingRepository(BookFlowDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> AddASync(Borrowing borrowing)
        {
            await _dbContext.Borrowings.AddAsync(borrowing);
            await _dbContext.SaveChangesAsync();

            return borrowing.Id;
        }

        public async Task<Borrowing> GetByIdAsync(int id)
        {
            var borrowing = await _dbContext.Borrowings.SingleOrDefaultAsync(b => b.Id == id);

            return borrowing;
        }
    }
}
