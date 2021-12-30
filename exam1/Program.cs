using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int num = 0;

            for (int i = 0; i < 10; i++)
            {
                num = random.Next(1000);

                Console.WriteLine(num.ToString() + ": " + GetString(num));
            }
        }

        public static string GetString(int num)
        {
            int d3 = 0;
            int d2 = 0;
            int d1 = 0;
            d1 = num % 10;
            d2 = (num / 10) % 10;
            d3 = num / 100;
            string s1 = "";
            string s2 = "";
            string s3 = "";
            string str = "";

            switch (d3)
            {
                case 1:
                    str += "сто ";
                    break;
                case 2:
                    str += "двести ";
                    break;
                case 3:
                    str += "триста ";
                    break;
                case 4:
                    str += "четыреста ";
                    break;
                case 5:
                    str += "пятьсот ";
                    break;
                case 6:
                    str += "шестьсот ";
                    break;
                case 7:
                    str += "семьсот ";
                    break;
                case 8:
                    str += "восемьсот ";
                    break;
                case 9:
                    str += "девятьсот ";
                    break;
            }
            switch (d2)
            {
                case 1:
                    switch (d1)
                    {
                        case 1:
                            str += "одинадцать";
                            break;
                        case 2:
                            str += "двенадцать";
                            break;
                        case 3:
                            str += "тринадцать";
                            break;
                        case 4:
                            str += "четырнадцать";
                            break;
                        case 5:
                            str += "пятнадцать";
                            break;
                        case 6:
                            str += "шестнадцать";
                            break;
                        case 7:
                            str += "семнадцать";
                            break;
                        case 8:
                            str += "восемнадцать";
                            break;
                        case 9:
                            str += "девятнадцать";
                            break;
                        case 0:
                            str += "десять";
                            break;
                    }
                    break;
                case 2:
                    str += "двадцать ";
                    break;
                case 3:
                    str += "тридцать ";
                    break;
                case 4:
                    str += "сорок ";
                    break;
                case 5:
                    str += "пятьдесят ";
                    break;
                case 6:
                    str += "шестьдесят ";
                    break;
                case 7:
                    str += "семьдесят ";
                    break;
                case 8:
                    str += "восемьдесят ";
                    break;
                case 9:
                    str += "девяносто ";
                    break;
            }
            if (d2 != 1)
            {
                switch (d1)
                {
                    case 1:
                        str += "один";
                        break;
                    case 2:
                        str += "два";
                        break;
                    case 3:
                        str += "три";
                        break;
                    case 4:
                        str += "четыре";
                        break;
                    case 5:
                        str += "пять";
                        break;
                    case 6:
                        str += "шесть";
                        break;
                    case 7:
                        str += "семь";
                        break;
                    case 8:
                        str += "восемь";
                        break;
                    case 9:
                        str += "девять";
                        break;

                }
                Console.ReadLine();
            }
            return str;
     
        }
    }
}
    

