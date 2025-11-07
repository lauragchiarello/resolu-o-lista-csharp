using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Aula06
{
     class LoopFor
    {
        public static void Executar()
        {
            int[] num = new int[10];
            for (int i = 0; i< num.Length; i++)
            {
                num[i] += 10;
                Console.WriteLine(num[i]);
            }
        }
    }
}
