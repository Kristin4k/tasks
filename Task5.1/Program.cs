using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("получить производные слова от слова чемодан");
            Console.ReadLine();

            string str = "";
            str = "Чемодан";

            string result = str.Substring(2, 1)
            + str.Substring(1, 1)
            + str.Substring(0, 1).ToLower();

            string result2 = str.Substring(4, 1)
                + str.Substring(1, 1)
                + str.Substring(2, 2)
                + str.Substring(6, 1);
         
            Console.WriteLine("Первое слово: " + result);
            Console.WriteLine("Второе слово: " + result2);
            Console.ReadKey();
        }
    }
}
