using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Aluno :Pessoa
    {
        public string Matricu { get; set; }
        public string Turma { get; set; }
        public IList<decimal> Notas { get; set; }
    }
}
