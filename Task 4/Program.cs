using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычислите");
            var x = X(Math.Sqrt(3) / 2) * X(Math.Tan((Math.Sqrt(2) / 4)) * X(Math.Tan((Math.Sqrt(7) / 5))));

            Console.WriteLine($"x = {(x):F3}");
            Console.ReadKey();
        }

        static double X(double k1)
        {
            return Math.Tan(k1);
        }

    }
}

