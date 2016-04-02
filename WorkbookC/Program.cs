using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkbookC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadz liczbe calkowita: ");
            int number = int.Parse(Console.ReadLine());

            if(number%2==0)
            {
                Console.WriteLine("Twoja liczba jest parzysta");
            }
            else
            {
                Console.WriteLine("Twoja liczba jest liczba nieparzysta");
            }
            if(number>=0)
            {
                Console.WriteLine("Twoja liczba nie jest ujemna");
            }
            else
            {
                Console.WriteLine("Twoja {0} jest ujemna", number);
            }
            Console.ReadLine();
        }
    }
}
