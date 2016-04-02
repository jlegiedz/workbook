using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3c
{
    class Program
    {
        static void Main(string[] args)
        {
            double janek = 50;
            double karol = 40;
            double dlug = 80;
            double splata = 0;
            int i = 1;

            do
            {
                splata += janek * 0.2 +karol * 0.2;
                Console.WriteLine(" Dzien {0} :na splate uzbierano {1} ", i++, splata);
               
            } while (dlug > splata);
            Console.ReadLine();

        }
    }
}
