using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Power(int one, int two)
            {
                float result = 1;
                for (int i = 0; i < two; i++)
                {
                    result *= one;
                }
                return result;
            }

            float Factorial(int nn)
            {
                float X = 1;

                for (int c = 1; c <= nn; c++)
                {
                    X *= c;
                }
                return X;
            }

            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите k: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите t: ");
            int t = int.Parse(Console.ReadLine());
            Console.Write("Введите x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите y: ");
            int y = int.Parse(Console.ReadLine());

            double answer = (Sqrt(Power(a,k) + Power(b,t)) / Factorial(x-b)) + Factorial(y);

            Console.WriteLine($"Ответ: {answer}");
        }
    }
}
