using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Верно ли что хотя бы одно из этих чисел k, m, n положительное?");
            int k;
            int m;
            int n;

            while (true)
            {
                Console.WriteLine("Введите значение числа k");
                while (!Int32.TryParse(Console.ReadLine(), out k))
                {
                    Console.WriteLine("Ответ некорректен, ошибка ввода");
                    Console.WriteLine("Введите значение числа k");
                }

                Console.WriteLine("Введите значение числа m");
                while (!Int32.TryParse(Console.ReadLine(), out m))
                {
                    Console.WriteLine("Ответ некорректен, ошибка ввода");
                    Console.WriteLine("Введите значение числа m");
                }

                Console.WriteLine("Введите значение числа n");
                while (!Int32.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Ответ некорректен, ошибка ввода");
                    Console.WriteLine("Введите значение числа n");
                }

                if (k >= 0 || m >= 0 || n >= 0)
                    Console.WriteLine("Да, верно");
                else
                    Console.WriteLine("Нет, неверно");

                Console.ReadKey();
            }
        }
    }
}
