using System;
using System.Diagnostics;
using MeuProjeto;

namespace ConsoleApp1.Aula02 { 
    class Notas
    {
        public static void Executar()
        {
            double n1, n2, n3, n4, res;
            res = n1 = n2 = n3 = n4 = 0;

            string resultado = "Reprovado";

            Console.Clear();

            Console.WriteLine(" Considere 4 notas e média maior ou igual a 7");
            Console.Write("Digite a nota 1: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota 2: ");
            n2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota 3: ");
            n3 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota 4: ");
            n4 = double.Parse(Console.ReadLine());

            res = (n1 + n2 + n3 + n4) / 4;


            if (res >= 7)
            {
                resultado = "Aprovado";
                Console.WriteLine($"A sua média é {res}. Parabéns! Você foi {resultado}!");
            }
            else
            {
                Console.WriteLine($"A sua média é {res}. Infelizmente você foi {resultado}");
            }

            Console.WriteLine("Deseja calcular outra média? [S] SIM | [N] NÃO");

            string continuar= Console.ReadLine();

            if(continuar == "Sim" || continuar =="S" || continuar == "s") {
                Executar();
            }
        }
    }

}