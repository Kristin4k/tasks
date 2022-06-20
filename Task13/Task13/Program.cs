using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название текстового файла:");
            string nameoffile = Console.ReadLine();
            //Console.WriteLine(File.OpenRead(FileName));
            //Console.WriteLine();
            //Console.WriteLine(File.Exists(FileName));
            //Console.WriteLine(File.ReadAllText(FileName));
            Console.WriteLine("Введите минимальную длинну слова:");
            int word = int.Parse(Console.ReadLine());
            Console.WriteLine("Обрабатыавю текст..");

            FileStream textsr = new FileStream("check.txt", FileMode.Open);
            StreamReader reading = new StreamReader(textsr);
            string str = reading.ReadToEnd();

            char[] dividers = { ' ', '\r', '\n', ',', '?', '-', '!' };
            int count = str.Split(dividers, StringSplitOptions.RemoveEmptyEntries)
                .Where(i => i.Length <= word).Count();
            //int count = str.Split(new char[] { ' ', '\r', '\n', ',', '?', '-', '!' },
            //    StringSplitOptions.RemoveEmptyEntries)
            //    .Where(i => i.Length <= word).Count();

            Console.WriteLine("Обработка завершена.");
            Console.WriteLine($"Слов в списке: {count} ");

            List<string> listOfWords = str.Split(dividers,
                StringSplitOptions.RemoveEmptyEntries).ToList();
            listOfWords.Sort();
            Console.WriteLine(string.Join(", ", listOfWords));
            

            //Console.WriteLine($"Список слов: {listOfWords}");
            Console.ReadKey();




            ////StreamReader sr = new StreamReader("story.txt");
            //Console.WriteLine("f");
            //var stringList = new List<string> { "story.txt" };
            //Console.WriteLine(File.ReadAllText("story.txt"));
        }
    }
}
