using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычислите функцию y = f(x)");
            double x;
            Console.WriteLine("Введите значение x");
            x = double.Parse(Console.ReadLine());
        }

        static double SolutionOfExample(double x)
        {
            if (x < -2)
            {
                Console.WriteLine($"f(x) = {x / 1}");
            }
            else if (x >= -2 && x <= 1)
            {
                Console.WriteLine($"f(x) = {Math.Pow(x, 2)}");
            }
            else
            {
                Console.WriteLine($"f(x) = {3 * Math.Pow(x, 3) - x}");
            }
            return x;
        }
    }
}
