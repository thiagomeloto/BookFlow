﻿using BookFlow.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFlow.Core.Repositories
{
    public interface IBorrowingRepository
    {
        Task<int> AddASync(Borrowing borrowing);
        Task<Borrowing> GetByIdAsync(int id);
    }
}
