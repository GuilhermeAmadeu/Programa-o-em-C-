using ExercicioPOO01.Heranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO01
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal saldoInicial = 0.0m;


            Console.Write("Informe o Saldo inicial da Conta: ");
            saldoInicial = Convert.ToDecimal(Console.ReadLine());

            ContaCorrente cc = new ContaCorrente(saldoInicial);

            

            Console.Write("Deseja realizar um Depósito (D) ou Saque (S): ");
            string opcao = Console.ReadLine();
            
            Console.Write("Informe o Valor: ");
            decimal valor = Convert.ToDecimal(Console.ReadLine());
            decimal saldo = 0.00m;
            for(int x = 0; x < 100; x++)
            {

            
            if (opcao == "S".ToLower())
            {
                if (saldoInicial-valor <= 0)
                {
                    Console.WriteLine("Você não possui Saldo para o Saque.");
                        break;
                }
                else
                {
                    saldo = cc.Saque(valor, DateTime.Now);
                    Console.Write("Saldo Final: {0:R$ ###,##0.00}", saldo);
                        break;
                }
            }    
            if (opcao == "D".ToLower())
            {
                saldo = cc.Deposito(valor, DateTime.Now);
                Console.Write("Saldo Final: {0:R$ ###,##0.00}", saldo);
                    break;
            }
            else
            {
                Console.WriteLine("Deseja realizar um Depósito (D) ou Saque (S): ");
                opcao = Console.ReadLine();
            }
            }
            Console.ReadKey();
            
        }
    }
}
