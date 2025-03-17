using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFlow.Core.Entities
{
    public class Book : BaseEntity
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string ISBN { get; private set; }
        public int YearPublication { get; private set; }

        public Book(string title, string author, string iSBN, int yearPublication)
        {            
            Title = title;
            Author = author;
            ISBN = iSBN;
            YearPublication = yearPublication;
        }
    }
}
