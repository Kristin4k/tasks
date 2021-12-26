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
            Console.WriteLine("введите слово чемодан, чтобы получить производные слова от него");
            string a = Console.ReadLine();
            string word = "чемодан";
            Console.WriteLine(a.Replace("чемодан", "демон"));
            Console.ReadKey();
            Console.WriteLine(a.Replace("чемодан", "меч"));
            Console.ReadKey();
        }
    }
}
