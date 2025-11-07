using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Aula05
{
    class Matrizes
    {
        public static void Executar()
        {
            /*Faça a matriz a seguir:
             * 10 20 30 40 50 
             * 60 70 80 90 15
             * 25 35 45 55 65*/
            int[,] n = new int[3, 5];
            n[0, 0] = 10;
            n[0, 1] = 20;
            n[0, 2] = 30;
            n[0, 3] = 40;
            n[0, 4] = 50;

            n[1, 0] = 60;
            n[1, 1] = 70;
            n[1, 2] = 80;
            n[1, 3] = 90;
            n[1, 4] = 15;

            n[2, 0] = 25;
            n[2, 1] = 35;
            n[2, 2] = 45;
            n[2, 3] = 55;
            n[2, 4] = 65;

            Console.WriteLine(n[2, 2]);


            Console.WriteLine("\nTreinando tabela com matrizes");
            string[,] tipos = new string[3,3];

            tipos[0, 0] = "Fruta";
            tipos[0, 1] = "Verduras";
            tipos[0, 2] = "Grãos";

            tipos[1, 0] = "Maçã";
            tipos[1, 1] = "Alface";
            tipos[1, 2] = "Lentilha";

            tipos[2, 0] = "Pêra";
            tipos[2, 1] = "Couve";
            tipos[2, 2] = "Grão de Bico";

            Console.WriteLine(tipos[2,0]);
            

        }
    }
}
