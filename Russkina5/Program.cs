using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russkina5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1, -3, 2, -2, -13, -14, 15, -1 };
            PrintArr(GetNegativeOddNumbersWithDigitOne(nums));
            Console.ReadKey();
        }

        static int[] GetNegativeOddNumbersWithDigitOne(int[] numbers)
        {
            return numbers.Where(n => n < 0 && n % 2 != 0 && n.ToString().Contains("1"))
                .OrderByDescending(n => n)
                .ToArray();
        }

        public static void PrintTotalDurationByYear(IEnumerable<Record> records)
        {
            var result = records.GroupBy(r => new { r.ClientID, r.Year })
                .Select(g => new { g.Key.ClientID, g.Key.Year, TotalDuration = g.Sum(r => r.Duration) })
                .OrderBy(r => r.ClientID)
                .ThenBy(r => r.Year);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.ClientID} {item.TotalDuration} {item.Year}");
            }
        }


        static void PrintArr(int[] Arr)
        {
            foreach (int i in Arr) Console.WriteLine(i);
        }
    }
}
