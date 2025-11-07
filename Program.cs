using System;
using ConsoleApp1.Aula02;
using ConsoleApp1.Aula03;
using ConsoleApp1.Aula04;
using ConsoleApp1.Aula05;
using ConsoleApp1.Aula06;

namespace MeuProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o exercício para executar:");
            Console.WriteLine("1 - Media Notas");
            Console.WriteLine("2 - Calculadora");
            Console.WriteLine("3 - Viagem");
            Console.WriteLine("4 - Matriz");
            Console.WriteLine("5 - LoopFor");
            Console.Write("Opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Notas.Executar();
                    break;
                case "2":
                    Calculadora.Executar();
                    break;
                case "3":
                    Viagem.Executar();
                    break;
                case "4":
                    Matrizes.Executar();
                    break;
                case "5":
                    LoopFor.Executar();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}