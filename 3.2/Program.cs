using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pierwsza liczba calkowita: ");
            int pierwsza = int.Parse(Console.ReadLine());

            Console.WriteLine("Druga liczba calkowita: ");
            int druga = int.Parse(Console.ReadLine());

            if (pierwsza % druga == 0)
            {
                Console.WriteLine("Liczba {1} jest dzielnikeim liczby {0}", pierwsza, druga);
            }
            else
            {
                Console.WriteLine("Liczba {1} nie jest dzielnikeim liczby {0}", pierwsza, druga);
            }

            Console.ReadLine();

        }  
    }
}
