using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam17
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] money = new long[6] { 100, 200, 500, 1000, 2000, 5000 }; // тип данных лонг, потому что банк
            money[0] = 100;
            money[1] = 200;
            money[2] = 500;
            money[3] = 1000;
            money[4] = 2000;
            money[5] = 5000;

            Console.WriteLine("Введите сумму, которую хотите снять.");
            long cash = Convert.ToInt64(Console.ReadLine());

            if ( cash % 100 == 0 && cash <= 50000)
            {
                Console.WriteLine("Сумма корректна,операция успешна, продолжение.");
            }
            else
            {
                Console.WriteLine("Сумма некоректна, автомат не может выдать данную сумму.");
            }
            

            Console.WriteLine("Какими купюрами автомат может выдать данную сумму?");
            long a, b, c, d, e, f;
            a = cash / money[0];
            b = cash / money[1];
            c = cash / money[2];
            d = cash / money[3];
            e = cash / money[4];
            f = cash / money[5];

            Console.WriteLine("Купюрами по 100, количество: " + a );
            Console.WriteLine("Купюрами по 200, количество: " + b);
            Console.WriteLine("Купюрами по 500, количество: " + c);
            Console.WriteLine("Купюрами по 1000, количество: " + d);
            Console.WriteLine("Купюрами по 2000, количество: " + e);
            Console.WriteLine("Купюрами по 5000, количество: " + f);

            Console.WriteLine("Сколькими способами мы можем получить эту сумму если использовать 2 купюры");

            //function = cash!/ (6 - cash)! * cash! формула сочетания, если брать 6 купюр  
            long n, factorial;
            n = cash;
            factorial = 1;
            for (long i = 2; i <= cash; i++ ) // с 2 потому что начинатьс 1 бессмысленно 
            {
                factorial = factorial * i; 
            }
            Console.WriteLine("факториал числа" + factorial);


            Console.ReadKey();



        }
        //static int CheckOfFactorial(int cash, int money) // проверка на факториал
        //{
        //    if (money == 0 || money == cash)
        //        return 1;
        //    else
        //        return CheckOfFactorial(cash - 1, money - 1) + CheckOfFactorial(cash - 1, money);
        //}
    }
}
