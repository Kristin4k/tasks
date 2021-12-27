using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_9
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowelletters = new char[20] { 'A', 'O', 'Э', 'Е', 'И', 'Ы', 'У', 'Ё', 'Ю', 'Я', 'а', 'о', 'э', 'е', 'и', 'ы', 'у', 'ё', 'ю', 'я' };

            Console.WriteLine("Введите любое русское слово, словосочетание или предложение:");
            var input = Console.ReadLine();
            int count = 0;
 
            for (int i = 0; i < input.Length; i++)
            {
                for (int e = 0; e < vowelletters.Length; e++)
                {
                    if (vowelletters[e] == input[i]) { count++; }
                }
            }
            Console.WriteLine($"Количество гласных букв в этом слове, словосочетании или предложении: {count}");
            Console.ReadLine();

        }
    }
}
