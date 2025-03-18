using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFlow.Core.Entities
{
    public class Borrowing
    {
        public int Id { get; private set; }
        public int IdUser { get; private set; }
        public int IdBook { get; private set; }
        public DateTime DateBorrowing { get; private set; }

        public Borrowing(int idUser, int idBook, DateTime dateBorrowing)
        {
            IdUser = idUser;
            IdBook = idBook;
            DateBorrowing = dateBorrowing;
        }
    }
}
