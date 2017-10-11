using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO02Restaurante.Heranca
{
    public class Pedido : FormaPagamento
    {
        Garcon IdGarcon;
        Cliente IdCliente;
        int IdPedido { get; set; }
        Produto IdProduto;
        Produto ValorProduto;
        decimal ValorTotal { get; set; }
        DateTime HoraAtendimento { get; set; }


    }
}
