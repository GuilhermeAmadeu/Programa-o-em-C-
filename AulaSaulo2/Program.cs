using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaSaulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, cidade, bairro;
            int idade;
            
            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite sua cidade: ");
            cidade = Console.ReadLine();
            Console.WriteLine("Digite o seu bairro: ");
            bairro = Console.ReadLine();
            Console.WriteLine("A pessoa " + nome + " sua idade é de " + idade + " anos mora em " + cidade + " no bairro " + bairro);
            Console.ReadKey();

        }
    }
}
