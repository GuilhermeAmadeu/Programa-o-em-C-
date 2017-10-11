using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO02Restaurante.Heranca
{
    class NotaCliente
    {
        DateTime EntradaCliente { get; set; }
        DateTime SaidaCliente { get; set; }
        Pedido HoraAtendimento;
        Pedido ValorTotal;
    }
}
