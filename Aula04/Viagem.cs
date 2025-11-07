using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Aula04
{
    class Viagem
    {
        public static void Executar()
        {
            int tempo = 0;
            char modo;

            Console.Clear();
            Console.WriteLine("Como você deseja viajar de Barra Bonita Para São Paulo?[A]Avião | [B]Ônibus | [C]Carro" );
            modo = char.Parse(Console.ReadLine());

            switch (modo)
            {
                case 'a':
                case 'A':
                    tempo = 60;
                    break;
                case 'b':
                case 'B':
                    tempo = 450;
                    break;
                case 'c':
                case 'C':
                    tempo = 240;
                    break;
                default: 
                    tempo = 0;
                    break;
            }

            if(tempo <= 0)
            {
                Console.WriteLine("Opção inválida");
            }
            else
            {
                Console.WriteLine("Para o transporte escolhindo, o tempo de viagem será de {0} minutos ", tempo);
            }
        }
    }
}
