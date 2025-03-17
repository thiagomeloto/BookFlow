using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFlow.Core.Entities
{
    public class Emprestimo
    {
        public int Id { get; private set; }
        public int IdUsuario { get; private set; }
        public int IdLivro { get; private set; }
        public DateTime DataEmprestimo { get; private set; }
    }
}
