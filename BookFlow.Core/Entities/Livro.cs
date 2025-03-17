using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFlow.Core.Entities
{
    public class Livro
    {
        public int Id { get; private set; }
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public string ISBN { get; private set; }
        public int AnoPublicacao { get; private set; }
    }
}
