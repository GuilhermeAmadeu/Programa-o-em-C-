using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaSaulo2Aritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {Console.ForegroundColor = ConsoleColor.Yellow;
            /*
             * int x, y, resultado;
             Console.Write("DIGITE UM NÚMERO: ");
             x = Convert.ToInt32(Console.ReadLine());
             Console.Write("DIGITE OUTRO NÚMERO: ");
             y = Convert.ToInt32(Console.ReadLine());
             resultado = x + y;
             Console.Write("A soma de {0} e {1} é: {2} ", x,y,resultado);
             Console.ReadLine();
             

            -----------------------------------------------------------------------------------------------------------------------------


            Calcular se é número par/impar  */

            /*
            int numero, resto;
            Console.WriteLine("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            resto = numero % 2;
            Console.WriteLine("O resto da divisão de {0} por 2 é {1}.", numero, resto);
            Console.ReadLine();

            -----------------------------------------------------------------------------------------------------------------------------

            EXERCICIO 1 */


            /*     
            
            Console.Write("Digite a base do retangulo : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a altura do retangulo : ");
            int y = Convert.ToInt32(Console.ReadLine());
            int area = x * y;
            Console.WriteLine("A área do seu Retângulo é {0}", area);
            Console.ReadKey();


            -----------------------------------------------------------------------------------------------------------------------------

            EXERCICIO 2  */

            /*Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite sua Idade: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual o Ano do seu Casamento: ");
            int casamento = Convert.ToInt32(Console.ReadLine());
            int resultado = 2017 - casamento;
            int resul = id - resultado;
            Console.Write("{0}, voce tinha {1} quando se casou em {2}.", nome, resul, casamento);
            Console.ReadKey();
            

            -----------------------------------------------------------------------------------------------------------------------------


             EXERCICIO 3  */

            /*Console.Write("Digite o Raio do Círculo: ");
            decimal raio = Convert.ToDecimal(Console.ReadLine());
            decimal cir = 2 * 3.14m * raio;
            decimal area = 3.14m * raio * raio;
            Console.Write("A área do Circulo é {0} e sua circunferência é {1}",area, cir);
            Console.ReadLine();

            ----------------------------------------------------------------------------------------------------------------------------
            
             EXERCICIO 4  */


            /*decimal altura, bas; 
            Console.Write("Digite a Altura do Triangulo: ");
            a = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite a Base do Triangulo: ");
            b = Convert.ToDecimal(Console.ReadLine());

            int area = a * b/ 2;

            Console.Write("A área do Triangulo é {0}", area);
            
            
            ----------------------------------------------------------------------------------------------------------------------------


             EXERCICIO 5  */

            /*Console.Write("Digite a ALTURA do Triângulo: ");
            decimal a = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite a BASE do Triângulo: ");
            decimal b = Convert.ToDecimal(Console.ReadLine());
            decimal h  = a * a  + b * b;
            decimal resul = h * h;
            Console.Write("A Hipotenusa do Triângulo é {0} .", h);
            Console.ReadKey();
            
            
            ----------------------------------------------------------------------------------------------------------------------------- 

             EXERCICIO 6 (opção 1) */

            /*int hora, mes;
            mes = 160;
          
            Console.Write("Digite o valor das horas: ");
            hora = Convert.ToInt16(Console.ReadLine());
            Console.Write("Digite as horas Trabalhadas da semana 1: ");
            int horat1 = Convert.ToInt16(Console.ReadLine());
            int semana1 = horat1 * hora;
            Console.Write("Digite as horas Trabalhadas da semana 2: ");
            int horat2 = Convert.ToInt16(Console.ReadLine());
            int semana2 = horat2 * hora;
            Console.Write("Digite as horas Trabalhadas da semana 3: ");
            int horat3 = Convert.ToInt16(Console.ReadLine());
            int semana3 = horat3 * hora;
            Console.Write("Digite as horas Trabalhadas da semana 4: ");
            int horat4 = Convert.ToInt16(Console.ReadLine());
            int semana4 = horat4 * hora;
            int horatotal = horat1 + horat2 + horat3 + horat4;
            int salario = semana1 + semana2 + semana3 + semana4 * hora;
           
            
            if (horatotal > 160)
            {
                decimal  resul = horatotal - 160;
                Console.WriteLine("Você trabalhou {0} horas extras.", resul);
                resul = resul * 1.5m;
                Convert.ToInt16( resul = resul + salario);
                Console.Write("O seu salário é de: {0}", resul);
                Console.ReadKey();
          
            }
            else
            {
                Console.Write("O seu salário é de: {0}", salario);
                Console.ReadKey();
            }
           
            
            ----------------------------------------------------------------------------------------------------------------------------- 

            
            EXERCICIO 6 (opção2) */  

            /*Console.Write("Escreva o Número de Horas Trabalhadas: ");
            int HorasT = Convert.ToInt16(Console.ReadLine());
            Console.Write("Escreva o Salário/Hora: ");
            decimal SalarioH = Convert.ToInt16(Console.ReadLine());
            int HorasE = Math.Max(HorasT - (4 * 40), 0);
            decimal SalarioT =
                (Math.Min(HorasT, 160) * SalarioH) +
                (HorasE * SalarioH * 1.5m);
            Console.WriteLine("O seu Salário Total é : {0:###,#0.00}", SalarioT);
            Console.ReadKey();
            
            
            ----------------------------------------------------------------------------------------------------------------------------- 
            
            
            EXERCICIO 7 */

            /*decimal CustoFabrica, CustoFinal;

            Console.Write("Informe o Custo Fábrica do Veículo: ");
            CustoFabrica = Convert.ToDecimal(Console.ReadLine());

            CustoFinal = CustoFabrica + (CustoFabrica * 0.28m) + (CustoFabrica * 0.45m);
            Console.WriteLine("O Custo Final para o Consumidor é: {0:###,##0.00}", CustoFinal);
            Console.ReadKey();
           
            ----------------------------------------------------------------------------------------------------------------------------- 
            
             
            */ 
            
         


            





        }
    }
}
