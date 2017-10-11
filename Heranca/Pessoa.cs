using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public abstract class Pessoa
    {
        public string Name { get; set; }
        
        public DateTime DataNascimento { get; set; }

        public string Endereco { get; set; }
    }
}
