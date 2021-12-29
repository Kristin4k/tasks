using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] englishLetters = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[] leet = { "4", "8", "(", "|)", "3", "|=", "6", "|-|", "!", ")", "|<", "1", @"|\/|", @"|\|", "0", "|>", "9", "|2", "5", "7", "|_|", @"\/", @"\/\/", "><", "'/", "2" };

            Console.WriteLine("Введите текст на английском языке");
            var input = Console.ReadLine();


            for (var i = 0; i < englishLetters.Length; i++)
                input = input.Replace(englishLetters[i], leet[i]);

            Console.WriteLine(input);
            Console.ReadKey();
        }
    }
}
