using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Power(int one, int two, out double result)
            {
                result = 1;
                for (int i = 0; i < two; i++)
                {
                    result *= one;
                }
            }
            void Factorial(int nn, out double X)
            {
                X = 1;

                for (int c = 1; c <= nn; c++)
                {
                    X *= c;
                }
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

            Factorial(x - b, out double xb);
            Factorial(y, out double y1);
            Power(a, k, out double ak);
            Power(b, t, out double bt);

            double answer = Sqrt(ak + bt) / xb + y1; ;

            Console.WriteLine($"Ответ: {answer}");
        }
    }
}

