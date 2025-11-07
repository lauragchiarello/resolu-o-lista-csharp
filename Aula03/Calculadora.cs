using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Aula03
{
    class Calculadora
    {
        public static void Executar()
        {

            Console.Clear();

            Console.WriteLine("Escolha a operação a ser realizada: ");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            string menu = Console.ReadLine();

            switch (menu)
            {
                case "1":
                    Adicao();
                    break;
                case "2":
                    Subtracao();
                    break;
                case "3":
                    Mult();
                    break;
                case "4":
                    Div();
                    break;
                default:
                    Console.WriteLine("Modo inválido");
                    Executar();
                    break;
            }
           
            Executar();
        }


        public static void Adicao()
        {
            int valor1, valor2, res;
            Console.WriteLine("Digite o primeiro número: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            valor2 = int.Parse(Console.ReadLine());

            res = valor1 + valor2;

            Console.WriteLine("a soma entre {0} e {1} é igual a {2}", valor1, valor2, res);
        }

        public static void Subtracao()
        {
            int valor1, valor2, res;
            Console.WriteLine("Digite o primeiro número: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            valor2 = int.Parse(Console.ReadLine());

            res = valor1 - valor2;

            Console.WriteLine("a subtração entre {0} e {1} é igual a {2}", valor1, valor2, res);
        }
        public static void Mult()
        {
            int valor1, valor2, res;
            Console.WriteLine("Digite o primeiro número: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            valor2 = int.Parse(Console.ReadLine());

            res = valor1 * valor2;

            Console.WriteLine("a multiplicação entre {0} e {1} é igual a {2}", valor1, valor2, res);
        }
        public static void Div()
        {
            int valor1, valor2, res;
            Console.WriteLine("Digite o primeiro número: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            valor2 = int.Parse(Console.ReadLine());

            if (valor1 == 0 || valor2 == 0)
            {
                Console.WriteLine("erro! não é possivel dividir por 0");
            }
            else
            {
                res = valor1 / valor2;
                Console.WriteLine("a divisão entre {0} e {1} é igual a {2}", valor1, valor2, res);
            }


        }


    }
}





