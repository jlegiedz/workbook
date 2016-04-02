using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwsza liczbe calkowita:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe calkowita:");
            int num2 = int.Parse(Console.ReadLine());

            if (num2 > num1)
            {
                for (int i = num1; i <= num2; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                for (int i = num2; i <= num1; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
