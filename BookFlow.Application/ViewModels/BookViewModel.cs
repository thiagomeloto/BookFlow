using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFlow.Application.ViewModels
{
    public class BookViewModel
    {
        public BookViewModel(int id, string title, string author, string iSBN, int yearPublication)
        {
            Id = id;
            Title = title;
            Author = author;
            ISBN = iSBN;
            YearPublication = yearPublication;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string ISBN { get; private set; }
        public int YearPublication { get; private set; }
    }
}
