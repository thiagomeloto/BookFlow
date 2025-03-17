using BookFlow.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFlow.Infrastructure.Persistence
{
    public class BookFlowDbContext : DbContext
    {
        public BookFlowDbContext(DbContextOptions<BookFlowDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Borrowing> Borrowings { get; set; }
    }
}
