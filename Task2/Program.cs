using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите гипотенузу");
            int b = Convert.ToInt32(Console.ReadLine());
            int x = 4 * a * 2;
            int k = a * (a + b);
            Console.WriteLine("Площадь вписанного квадрата в окружность " + x);
            Console.WriteLine("Площадь вписанного правильного треугольнака в окружность " + k);


            Console.ReadKey();
        }
    }
}


