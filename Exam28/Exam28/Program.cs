using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam28
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNum = Convert.ToInt32("11111111111111111111111111111111", 2);
            int num = 0;
            int summ = 0;
            while (num >= maxNum)
            {
                summ = summ + L(IntToS(num));
                num++;
            }
            Console.WriteLine(summ);
            Console.ReadKey();
        }
        static int L(char[] s) 
        {
            int maxCount = 0;
            int count = 0;
            for (int e = 1; e < s.Length; e++)
            {
                if (s[e] == s[e - 1])
                {
                    count++;
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                    count = 0;
                }
            }
            return maxCount;

        }
        static char[] IntToS(int i)
        {
            char[] a = new char[32];
            for (int e = 0; e != 31; e++)
            {
                a[e] = '0';
            }


            string s = Convert.ToString(i, 2);

            int c = 0;
            for (int e = s.Length - 1; e >= 0; e--)
            {
                a[c] = s[e];
                c++;
            }
            return a;
        }
    }

}
