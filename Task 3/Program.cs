using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычислите функцию y = f(x)");
            Console.WriteLine("Введите значение переменной x");
            var x = double.Parse(Console.ReadLine());

            Console.WriteLine($"f(x) = {Function(x):F3}");

            Console.ReadKey();
        }
        static double Function(double x)
        {
            return Math.Sqrt(Math.Sin(x) * Math.Sin(2 * x) * Math.Sin(3 * x) * Math.Sin(4 * x));
        }
    }
}
