using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double CalculateHypotenuse(double one, double two)
            {
                double p = 1;
                double answer = 0;

                p = Pow(one, 2) + Pow(two, 2);
                answer = Sqrt(p);


                return (float)answer;
            }

            Console.Write("Введите катет A: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите катет B: ");
            double b = double.Parse(Console.ReadLine());
            double s = CalculateHypotenuse(a, b);

            Console.WriteLine($"Для катетов {a} и {b} гипотенуза равна {s}");
        }
    }
}
