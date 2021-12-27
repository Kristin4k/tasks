using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности");
            var radius = double.Parse(Console.ReadLine());
            var AreaOfSquare = 2 * Math.Pow(radius, 2);
            var AreaOfEquilateralTringle = 3 * Math.Sqrt(3) * Math.Pow(radius, 2) / 4;

            Console.WriteLine("Площадь вписанного квадрата в окружность " + AreaOfSquare);
            Console.WriteLine("Площадь вписанного правильного треугольнака в окружность " + AreaOfEquilateralTringle);

            Console.ReadKey();
        }
    }
}
