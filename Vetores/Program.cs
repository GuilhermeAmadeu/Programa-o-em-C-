using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio 1


            //string[] nomes = new string[10];
            //for (int x = 0; x < 10; x++)
            //{
            //    Console.Write("Informer o Nome do Aluno {0}: ", (x + 1));
            //    nomes[x] = Console.ReadLine();
            //}
            //for (int x = 10;x > 0;x--)
            //{
            //    Console.WriteLine(nomes[x-1]);
            //}
            //Console.ReadLine();


            // Exercicio 2


            //int[] Nota = new int[10];
            //int media = 0,resul;
            //for (int x = 0; x < 10; x++)
            //{
            //    Console.Write("Informer Nota do Aluno {0}: ", (x + 1));
            //    Nota[x] =Convert.ToInt16( Console.ReadLine());
            //    media =Nota[x]+media;
            //}
            //for (int x = 10; x > 0; x--)
            //{
            //    Console.WriteLine("Aluno {0} : {1}. ",x,Nota[x - 1]);
            //}
            //resul = media / 10;
            //Console.WriteLine("A sua Média é : {0}.", resul);
            //Console.ReadLine();


            // Exercicio 3


            //string[] nomes = new string[10];
            //for (int x = 0; x < 10; x++)
            //{
            //    Console.Write("Informer o Nome {0}: ", (x + 1));
            //    nomes[x] = Console.ReadLine();
            //}
            //int posicao=-1;
            //string procura,mensagem;
            //Console.Write("Digite um nome para procurar entre os 10 números informados: ");
            //procura = Console.ReadLine();
            //mensagem = "NÃO ACHEI";
            //for (int x = 0; x < 10; x++)
            //{
            //    if (nomes[x] == procura)
            //    {
            //        posicao = x;
            //        mensagem = "ACHEI!!!";
            //        break; //opcional - Interrompe o FOR
            //    }
            //}
            //Console.Write("{0}", mensagem);
            //if (posicao >= 0)
            //{
            //    Console.Write("Posição: {0}", (posicao + 1));
            //}
            //Console.ReadLine();


            // Exercicio 1 Matriz

            //string[] Produtos = new string[5];
            //decimal[,] valor = new decimal[5, 5];
            //Console.Write("Digite o seu Nome: ");
            //string nome = Console.ReadLine();
            //Console.Write("Digite o seu Telefone: ");
            //string telefone = Console.ReadLine();
            //Console.Write("Digite o seu Email: ");
            //string email = Console.ReadLine();
            //int P;
            //decimal total=0;
            //for (P=0; P < 5; P++)
            //{
            //    Console.Write("Digite o Nome do produto {0}: ", P+1);
            //    Produtos[P] = Console.ReadLine();
            //    Console.Write("Digite o Valor do Produto {0}: ",P+1 );
            //    valor[P,P] = Convert.ToDecimal(Console.ReadLine());

            //}
            //for (P = 0; P < 5; P++)
            //{
            //    Console.WriteLine("{0} valor: {1}.",Produtos[P], valor[P, P]);
            //    total = total + valor[P, P];

            //}
            //Console.WriteLine(" Seu Nome: {0}. \n Seu Telefone: {1}. \n Seu Email: {2}. \n E o Valor total dos produtos são: {3}.", nome, telefone, email, total);

            //    Console.ReadKey();


            // Exercicio 4

            //int[] Numeros = new int[20];
            //int maior = 0, menor = 9999999;
            //for (int Q = 1; Q <= 7; Q++)
            //{
            //    Console.Write("Digite o Número {0}: ", Q);
            //    Numeros[Q] = Convert.ToInt32(Console.ReadLine());
            //    if (Numeros[Q]<0)
            //    {
            //        Console.WriteLine("Desculpe Digite um Número positivo: ");
            //        Numeros[Q] = Convert.ToInt32(Console.ReadLine());
            //    }
            //    if (Numeros[Q] > maior)
            //    {
            //        maior = Numeros[Q];
            //        Console.WriteLine("A posição do número maior é {0} e a posição é: {1}", maior,      Q);

            //    }
            //    if (Numeros[Q] < menor)
            //    {
            //        menor = Numeros[Q];
            //        Console.WriteLine("A posição do número menor é {0} e a posição é: {1} ",menor , Q);
            //    }
            //}
            //Console.ReadKey();


            // Exercicio 5


            //int[] Numeros = new int[20];
            //int[] Impar = new int[40];
            //int x;
            //for (x = 0; x < 20; x++) 
            //{
            //    Console.Write("Digite o Número {0}: ", x+1);
            //    Numeros[x] = Convert.ToInt32(Console.ReadLine());
            //    for (int n = 0; n < 5; n++)
            //    {
            //        if ((Numeros[x] % 2) == 1)
            //        {
            //        Impar[x]= Numeros[x];
            //        }
            //    }
            //}
            //Console.Write("Os Números impares são: ");
            //for(int i = 0; i < 20; i++)
            //{
            //    if (Impar[i] > 0)
            //    {
            //        Console.Write(" {0},",Impar[i]);
            //    }
            //}
            //Console.ReadKey();


            // Exercicio 6


            //int[] Numeros = new int[5];
            //for (int x = 0; x < 5; x++)
            //{
            //    Console.Write("Digite o Número {0}: ", x + 1);
            //    Numeros[x] = Convert.ToInt32(Console.ReadLine());

            //}
            //Console.Write("Digite o Número que você deseja procurar: ");
            //int procurar = Convert.ToInt32(Console.ReadLine());
            //int repetidos = 0;
            //for(int x = 0; x < 5; x++)
            //{
            //    if(Numeros[x] == procurar)
            //    {

            //        repetidos = repetidos + 1;
            //    }
            //}
            //Console.Write("O Número {0} esta repetindo {1} vezes no vetor.", procurar, repetidos);
            //Console.ReadKey();






            // Exercicio 1


            //int[] A = new int[10];
            //int[] M = new int[10];
            //for(int x = 0; x < 10; x++)
            //{
            //    Console.Write("Digite o Número {0}: ", x + 1);
            //    A[x] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.Write("Digite um Número para ser o multiplicador: ");
            //int X = Convert.ToInt32(Console.ReadLine());
            //for(int x = 0; x < 10; x++)
            //{
            //    M[x] = A[x] * X;
            //    Console.WriteLine("O Número {0} x {1} = {2}. ", A[x], X, M[x]);

            //}
            //Console.ReadKey();


            // Exercicio 2


            //int[] V1 = new int[15];
            //int[] V2 = new int[15];
            //int iguais=0;
            //for(int x = 0; x < 15; x++)
            //{
            //    Console.Write("Digite o Número {0} para o vetor 1: ", x + 1);
            //    V1[x] = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Digite o Número {0} para o vetor 2: ", x + 1);
            //    V2[x] = Convert.ToInt32(Console.ReadLine());

            //}
            //for (int x = 0; x < 15; x++)
            //{
            //    for(int y = 0; y < 15; y++)
            //    {
            //        if (V1[x] == V2[y])
            //        {
            //            iguais = iguais + 1;
            //        }
            //    }
            //}
            //Console.Write("Os 2 Vetores têm {0} números repetidos entre eles.", iguais);
            //Console.ReadKey();



            // Exercicio 3

            //int[] Vetor1 = new int[5];
            //for (int x = 0; x < 5; x++)
            //{
            //    Console.Write("Digite o Número {0}: ", x + 1);
            //    Vetor1[x] = Convert.ToInt32(Console.ReadLine());
            //}
            //for(int x = 0; x < 5; x++)
            //{
            //    for(int n = 0; n < 5; n++)
            //    {
            //        if (Vetor1[x] == Vetor1[n])
            //        {
            //            Console.WriteLine("O número {0} é repetido e esta na posição {1}.", Vetor1[x], x + 1);

            //        }
            //    }
            //}
            //Console.ReadKey();


            // Exercicio 4


            string NomeCliente;
            int ValorTotal = 0, CodP = 1,QtdPedido=0;
            string[] NomeP = new string[15];

            int[] Valor = new int[15];
            int[] ProdCliente = new int[15];
            int[] Qtd = new int[15];
            for (int x = 1; x <= 2; x++)
            {
                Console.WriteLine("Digite o nome do produto: ");
                NomeP[x] = Console.ReadLine();
                Console.WriteLine("Digite o valor do produto: ");
                Valor[x] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Digite o seu Nome: ");
            NomeCliente = Console.ReadLine();
            Console.WriteLine("Os Codigos dos Produtos e os preços: ");
            for (int x = 1; x <= 2; x++)
            {
                Console.WriteLine("codigo {0} Produto {1} R$ {2}", CodP++, NomeP[x], Valor[x]);
            }
            for (int y = 1; y <= 999999; y++)
            {
                Console.WriteLine("Digite o codigo do produto que deseja inlcuir no pedido caso ja tenha incluido todos os produtos no pedido digite (99): ");
                ProdCliente[y] = Convert.ToInt32(Console.ReadLine());
                if (ProdCliente[y] == 99)
                {
                    break;
                }
                Console.WriteLine("Digite a quantidade do produto: ");
                Qtd[y] = Convert.ToInt32(Console.ReadLine());
                ValorTotal = (Valor[ProdCliente[y]] * Qtd[y]) + ValorTotal;
                QtdPedido = QtdPedido + Qtd[y];
            }

            Console.WriteLine("Olá {0} você selecionou {1} produtos o valor total do seu pedido foi R${2} .",NomeCliente,QtdPedido, ValorTotal);
            Console.ReadKey();


        }

    }
}
