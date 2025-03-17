using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFlow.Core.Entities
{
    public class Book
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string ISBN { get; private set; }
        public int YearPublication { get; private set; }
    }
}
