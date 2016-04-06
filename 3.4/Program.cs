using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwsza liczbe: ");
            string a = Console.ReadLine();

            double aDoub = 0;

            while (!double.TryParse(a, out aDoub))
            {
                Console.WriteLine("To nie jest liczba. Sprobuj ponownie ");
                Console.WriteLine("Podaj pierwsza liczbe :");
                a = Console.ReadLine();
            }

            Console.WriteLine("Podaj druga liczbe: ");
            string b = Console.ReadLine();

            double bDoub = 0;
            
            while (!double.TryParse(b, out bDoub))
            {
                Console.WriteLine("To nie jest liczba. Sprobuj ponownie ");
                Console.WriteLine("Podaj druga liczbe :");
                b = Console.ReadLine();
            }

            Console.WriteLine("Jakie dzialanie chcesz wykonac: +, -, * czy / ?");
            string znak = Console.ReadLine();


            switch (znak)
            {
                case "+":
                    Console.WriteLine("a + b = {0}", aDoub + bDoub);
                    break;
                case "-":
                    Console.WriteLine("a - b = {0}", aDoub - bDoub);
                    break;
                case "*":
                    Console.WriteLine("a * b = {0}", aDoub * bDoub);
                    break;
                case "/":
                    Console.WriteLine(" a / b = {0}", aDoub / bDoub);
                    break;
                default:
                    Console.WriteLine("podano zle dane");
                    break;
            }

            Console.ReadLine();
        }
    }
}
