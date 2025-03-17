using BookFlow.Core.Entities;
using BookFlow.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFlow.Infrastructure.Persistence.Repositories
{
    public class BorrowingRepository : IBorrowingRepository
    {
        public Task<int> AddASync(Borrowing borrowing)
        {
            throw new NotImplementedException();
        }
    }
}
