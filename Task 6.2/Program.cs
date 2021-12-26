using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Принадлежит ли точка с коардинатами(x, y)  указанной области?");
            double x;
            double y;

            Console.WriteLine("Введите значение x");
            Console.Write("x = ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            Console.Write("y = ");
            y = double.Parse(Console.ReadLine());

            if (x > 2 && y > 0.5 && y < 1.5)
            {
                Console.WriteLine("Точка принадлежит указанной области");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит указанной области");
            }
            Console.ReadKey();
        }
    }
    
}
