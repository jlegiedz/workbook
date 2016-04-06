using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwsza liczbe calkowita: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe calkowita: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzecia liczbe calkowita: ");
            int c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("Najwieksza liczba to: " + a);
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("Najwieksza liczba to: " + b);
                }
                else
                {
                    if (c > a)
                    {
                        Console.WriteLine("Najwieksza liczba to : " + c);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}      
   

