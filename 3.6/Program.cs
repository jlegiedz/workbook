using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jaka jest twoja waga w kilogramach?");
            double waga = double.Parse(Console.ReadLine());
            Console.WriteLine("Jaki jest Twoj wzrost w m?");
            double wzrost = double.Parse(Console.ReadLine());

            double BMI = waga / (Math.Pow(wzrost, 2));

            if (BMI <= 18.5)
            {
                Console.WriteLine("Masz niedowage");
            }
            else if (BMI >= 25)
            {
                Console.WriteLine("Masz nadwage");
            }
            else
            {
                Console.WriteLine("Wartosc prawidlowa");
            }

            Console.ReadLine();
        }
    }
}
