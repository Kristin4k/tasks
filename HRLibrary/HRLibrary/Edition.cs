using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Edition
    {
        public string Name;
        public string Authors;
        public int Year;
        public string Office;
        public int Number /*{ get; }*/;
        public readonly ActiveStatus Status;
        public double Price;
            
        public Edition (string name, string authors, int year, string office, int number )
        {
            Name = name;
            Authors = authors;
            Year = year;
            Office = office;
            Number = number;

        }

        public override string ToString()
        {
            return $"{Name}, {Authors}";
        }


        public void PrintInfo(Edition e)
        {
            Console.WriteLine(this);

            var status = " ";

            switch(Status)
            {
                case ActiveStatus.InTheStorage:
                    status = "в хранилище";
                    break;
                case ActiveStatus.OnlyForReadingHoll:
                    status = "выдана в читательный зал";
                    break;
                case ActiveStatus.ForGettingToHome:
                    status = "выдана на дом";
                    break;
            }

            Console.WriteLine($"Год издания: {e.Year}. Издательство: {e.Office}. Инвентарный номер: {e.Number}. Статус: {status}. Цена в рублях: {e.Price:F2}" );
            Console.ReadKey();
        }
        
    }
}
