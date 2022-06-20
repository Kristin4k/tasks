using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public abstract class Literate : Edition
    {
        public int TimeofWritting;
        public int ListsofBook;
        public Literate() : base("WarandPeace", "Tolstoy", 2010, "Eksmo", 001)
        {

        }
    }
}
