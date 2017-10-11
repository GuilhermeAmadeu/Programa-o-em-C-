using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios23082017
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCICIOS

            // Exercicio 1

            //Console.WriteLine("Digite sua idade: ");
            //int idade = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("E quantos mêses: ");
            //int mes = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("E dias: ");
            //int dias = Convert.ToInt32(Console.ReadLine());
            //int resulid = idade * 365;
            //int resulmes = mes * 30;
            //int resulfinal = resulid + resulmes + dias;
            //Console.WriteLine("Você ja viveu {0}.", resulfinal);
            //Console.ReadKey();


            // Exercicio 2

            //Console.Write("Quantos Eleitores têm no seu municipio: ");
            //decimal eleitores = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Quantos Eleitores votaram Brancos: ");
            //decimal brancos = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Quantos Eleitores votaram nulos: ");
            //decimal nulos = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Quantos Eleitores votaram válidos: ");
            //decimal validos = Convert.ToDecimal(Console.ReadLine());
            //decimal resulbran = (brancos / eleitores) * 100;
            //Console.Write("{0:###,#0.00}%", resulbran);
            //Console.ReadKey();

            // Exercicio 3

            //Console.Write("Digite o seu Sálario: ");
            //decimal salario = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Digite quanto foi o reajuste: ");
            //decimal reajuste = Convert.ToDecimal(Console.ReadLine());
            //decimal resultado = salario + (salario * reajuste);
            //Console.Write("O seu sálario ficou em {0:###,#0.00}", resultado);
            //Console.ReadKey();

            // Exercicio 4

            //Console.Write("Digite o valor da cotação do dólar: ");
            //decimal dolar = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Digite o valor em reais que você deseja converter: ");
            //decimal reais = Convert.ToDecimal(Console.ReadLine());
            //decimal resul = reais / dolar;
            //Console.Write("Você tem {0:###,#0.00} em dólar.", resul);
            //Console.ReadKey();

            // Exercicio 5

            //Console.Write("Informe quantos carros foram vendidos: ");
            //decimal carros = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Informe o valor total de suas vendas: ");
            //decimal vendas = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Informe seu sálario fixo: ");
            //decimal salario = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Informe o valor a receber dos carros vendidos: ");
            //decimal carrosvendidos = Convert.ToDecimal(Console.ReadLine());
            //decimal vendidos = carrosvendidos * carros;
            //decimal salariofinal = (vendidos * 0.05m)+ salario;
            //Console.Write("O seu Sálario é de {0} ", salariofinal);
            //Console.ReadKey();

            // Exercicio 6

            // Exercicio 7

            //Console.Write("Digite a primeira nota: ");
            //decimal n1 = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Digite a segunda nota: ");
            //decimal n2 = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Digite a terceira nota: ");
            //decimal n3 = Convert.ToDecimal(Console.ReadLine());
            //decimal mediafinal = (n1 * 2 + n2 * 3 + n3 * 5)/10;
            //Console.Write("A sua média é {0}.", mediafinal);
            //Console.ReadKey();


            // Exercicio 8

            //Console.Write("Digite quantas maças você comprou: ");
            //decimal macas = Convert.ToDecimal(Console.ReadLine());
            //if (macas < 12)
            //{
            //    decimal resul = macas * 1.30m;
            //    Console.WriteLine("Você comprou {0} e gastou {1}.",macas, resul);
            //}
            //if(macas >= 12)
            //{
            //    decimal resul = macas * 1m;
            //    Console.WriteLine("Você comprou {0} e gastou {1}.", macas, resul);
            //}
            //Console.ReadKey();


            // Exercicio 9

            //Console.WriteLine("Digite o Primeiro valor: ");
            //decimal n1 = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Digite o Segundo valor: ");
            //decimal n2 = Convert.ToDecimal(Console.ReadLine());
            //if (n1 > n2)
            //{
            //    Console.Write("O número maior é {0}.", n1);
            //}
            //if (n2 > n1)
            //{
            //    Console.Write("O número maior é {0}.", n2);
            //}
            //Console.ReadKey();


            // Exercicio 10

            //Console.Write("Escreva seu Nome: ");
            //string nome = Console.ReadLine();
            //Console.Write("Se você é Homen digite 1 ou Mulher digite 2: ");
            //int sexo = Convert.ToInt16(Console.ReadLine());


            //if (sexo == 1 )
            //{
            //Console.Write("Digite sua altura: ");
            // decimal altura = Convert.ToDecimal(Console.ReadLine());
            // decimal peso_ideal = (72.7m * altura) - 58m;
            // Console.Write("Seu peso Ideal é: {0}", peso_ideal);
            //}
            //else
            //{
            //    Console.Write("Digite sua altura: ");
            //    decimal altura = Convert.ToDecimal(Console.ReadLine());
            //    decimal peso_ideal = (62.1m * altura) - 44.7m;

            // Console.Write("Seu peso Ideal é: {0}", peso_ideal);
            //}
            //Console.ReadKey();


            // Exercicio 11

            //Console.Write("Qual foi o seu sálario fixo: ");
            //decimal salario = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Digite o valor das vendas efetuadas: ");
            //decimal vendas = Convert.ToDecimal(Console.ReadLine());
            //if (vendas < 1.500m)
            //{
            //    decimal salariofinal = (vendas * 0.03m) + salario;
            //    Console.WriteLine("O seu Sálario Final é {0}.", salariofinal);
            //}
            //if (vendas > 1.500m)
            //{
            //    decimal salariofinal = ((vendas - 1.500m) * 0.03m) + salario;
            //    Console.WriteLine("O seu Sálario Final é {0:###,#0.00}.", salariofinal);
            //}
            //Console.ReadKey();

            // Exercicio 12


            Console.Write("Digite o Número da sua conta: ");
            decimal conta = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite o Saldo da conta: ");
            decimal saldo = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite o válor em Débito na conta: ");
            decimal debito = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite o válor em Crédito na conta: ");
            decimal credito = Convert.ToDecimal(Console.ReadLine());
            decimal saldoatual = saldo - debito + credito;
            if (saldoatual > 0)
            {
                Console.WriteLine("Saldo Positivo.");
            }
            if (saldoatual == 0)
            {
                Console.WriteLine("Saldo Zerado.");
            }
            if (saldoatual < 0)
            {
                Console.WriteLine("Saldo Negativo.");
            }
            Console.ReadKey();
        }
    }
}
