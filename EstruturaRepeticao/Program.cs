using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            ExercicioFor10();
            
            Console.ReadKey();
            

        }
        private static void ExemploFor01()
        {
            for (int x = 1; x <=10; x++)
            {
                Console.WriteLine("O Valor de x é: {0}.", x);
            }
        }
        private static void ExemploFor02()
        {
            for (int j = 0; j <= 10; j += 2)
            {
                Console.WriteLine("O Valor de J é: {0}.", j);
            }
        }
        private static void ExercicioFor01()
        {
            Console.Write("Digite o Número A: ");
            int numA = Convert.ToInt16(Console.ReadLine());
            Console.Write("Digite o Número B: ");
            int numB = Convert.ToInt16(Console.ReadLine());
            for (int x = 0; x <= numB; x++)
            {
                int resul = numA * x;
                Console.WriteLine("{0} x {1} = {2}. ",numA,x,resul);
            }
        }
        private static void ExercicioFor02()
        {
            int resul=0;
            
            for (int x = 0; x < 10; x++)
            {
                Console.Write("Digite o numero {0}: ",x);
                int numero = Convert.ToInt16(Console.ReadLine());
                resul = numero + resul;
            }
           
            Console.WriteLine("Sua Média é: {0}",resul/10);       
            Console.ReadKey();
        }
        private static void ExercicioFor03()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            int n1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            int n2 = Convert.ToInt16(Console.ReadLine());
            int par = 0;
            for (int x = n1+1;x < n2; x++)
            {
                if(x % 2 == 0)
                    //soma +=(x % 2 ==0 ? x : 0); //Operador Ternário | if Ternário
                {
                    par = par + x;
                    
                }
                
            }
            Console.Write("A soma dos números pares entre os 2 números digitados são: {0}",par);
            Console.ReadKey();
        }
        private static void ExemploDoWhile01()
        {
            int Y;
            Console.Write("Digite um número: ");
            Y = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("O valor de Y é: {0}", Y);
                //Y--;
                Y = Y - 1;
            } while (Y > 0);
        }
        private static void ExercicioFor04()
        {
            int maior=0, menor=999999999, numero;
            Console.WriteLine("Digite 30 Números.");
            for (int x = 1; x <30; x++)
            {
                Console.Write("Digite o Número {0}: ", x);
                numero = Convert.ToInt32(Console.ReadLine());
                
                if (numero > maior)
                {
                    maior = numero;
                      
                }
                if (numero < menor)
                {
                    menor = numero;
                }  
                
            }
            Console.WriteLine("O maior Númeoro é {0}.", maior);
            Console.WriteLine("E o menor Número é {0}.", menor);
            Console.ReadKey();

        }
        private static void ExercicioFor05()
        {
            

            Console.Write("Digite um Número: ");
            int N = Convert.ToInt32(Console.ReadLine());
            do 
            {
                N = N - 1;
                Console.WriteLine("{0}", N);
            }
            while (N>1);
            Console.ReadKey();
        }
        private static void ExercicioFor06()
        {
            int soma=0, subtracao=0, multiplicacao=1;
            Console.WriteLine("Digite 15 Números.");
            for (int x = 1; x <= 15; x++)
            {
                Console.Write("Digite o numero {0}: ", x);
                int numero = Convert.ToInt16(Console.ReadLine());
                soma =soma +numero  ;
                subtracao =   subtracao-numero;
                multiplicacao = multiplicacao*numero  ;
            }
            Console.WriteLine("A soma de todos os Números é {0}. /n A subtração de todos os Números é {1}. /n A multiplicação de todos os Números é {2}.", soma, subtracao, multiplicacao);
            Console.ReadKey();
        }
        private static void ExercicioFor07()
        {
            int numero,soma=0,multiplicacao=1;
            Console.WriteLine("Digite 10 Números: ");
            for (int x = 1; x <= 10; x++)
            {
                Console.Write("Digite o Número {0}:", x);
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero > 20)
                {
                    soma = soma + numero;
                }
                if (numero < 10)
                {
                    multiplicacao = multiplicacao * numero;
                }
            }
            Console.WriteLine("A soma dos valores digitados a cima de 20 são {0}.", soma);
            Console.WriteLine("A multiplicação dos valores digitados a baixo de 10 são {0}.", multiplicacao);
        }
        private static void ExercicioFor08()
        {
            Console.WriteLine("Digite um número");
            int numeroAnterior = 0;
            int numeroAtual = 1;
            int fibonacci=1;
          
            


            do
            {
                Console.WriteLine(fibonacci);
                fibonacci = numeroAnterior + numeroAtual;
                
                numeroAnterior = numeroAtual;
                numeroAtual = fibonacci;
            } while (fibonacci < 20);
            Console.ReadKey();
        }
        private static void ExercicioFor09()
        {
            int fatorial=1, numero;
            Console.Write("Digite um Número para exibir o Fatorial dele: ");
            numero = Convert.ToInt16(Console.ReadLine());
            for (int x = 0; x < numero; x++)
            {
                fatorial = (x ==0 ? 1 : fatorial * (x+1));
                if (x <numero)
                {
                    
                }
            }
            Console.WriteLine("O Fatorial é: {0}", fatorial);
                        
        }
        private static void ExercicioFor10()
        {
            Console.Write("Digite um Número: ");
            int numero = Convert.ToInt16(Console.ReadLine());
            for (int x =0; x <= numero; x++)
            {
                Console.Write("O Número {0}² é : {1} ", numero,x);
                x = numero * numero;
                
            }
        }
    }
}
