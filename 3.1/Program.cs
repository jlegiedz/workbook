using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rok: ");
            int rok = int.Parse(Console.ReadLine());

            if (rok % 4 == 0 && (rok % 100 != 0 || rok % 400 == 0))
            {
                Console.WriteLine("rok {0} jest rokiem przestepnym", rok);
            }
            else
            {
                Console.WriteLine("rok {0} nie jest rokiem przestepnym", rok);
            }
            Console.ReadLine();
        }
    }
}
