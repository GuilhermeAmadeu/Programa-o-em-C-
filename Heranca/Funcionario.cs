using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Funcionario : Pessoa
    {
        public string CTPS {get;set;}
        public IList<DateTime>HorarioTrabalho {get;set;}
        public DateTime DataAdmissao {get;set;}
        public DateTime DataDemissao {get;set;}
        public decimal Salario {get;set;}
        
        
    }
}
