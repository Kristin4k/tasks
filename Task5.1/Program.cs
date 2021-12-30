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
            Console.WriteLine("получить производные слова от чемодан");
            Console.ReadLine();
            string s1 = "ч";
            string s2 = "е";
            string s3 = "м";
            string s4 = "о";
            string s5 = "д";
            string s6 = "а";
            string s7 = "н";
            string word1 = s5 + s2 + s3 + s4 + s7;
            string word2 = s3 + s2 + s1;
            Console.WriteLine(word1);
            Console.WriteLine(word2);
            Console.ReadKey();
        }
    }
}
