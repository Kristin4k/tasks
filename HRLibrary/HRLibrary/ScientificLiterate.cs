using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class ScientificLiterate : Literate
    {
        public string ScientificField;
        public string Annotation;



        public ScientificLiterate(string name, string authors, int year, string office, 
            int number, string scientificfield, string annotation): 
            base (name, authors, year, office, number)
        {
            ScientificField = scientificfield;
            Annotation = annotation;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Научно техническая литература в области {ScientificField} с аннотацией {Annotation}");
            Console.WriteLine($"Период написания {TimeofWritting} книги с таким {ListsofBook} количеством страниц");
        }
    }
}
