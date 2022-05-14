using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;
using NUnit.Framework;

namespace HRLibrary.Unit.Tests
{
    [TestFixture]
    public class EditionUnitTest
    {
        [Test]
        public void ConstructorTest()
        {
            var warandpeace = CreateTestEdition();

            Assert.AreEqual("WarandPeace", warandpeace.Name);
            Assert.AreEqual("Tolstoy", warandpeace.Authors);
            Assert.AreEqual(2010,  warandpeace.Year);
            Assert.AreEqual("Eksmo", warandpeace.Office);
            Assert.AreEqual(001, warandpeace.Number);
            Assert.AreEqual(ActiveStatus.InTheStorage, warandpeace.Status);
            Assert.AreEqual(354, 354, warandpeace.Price );

        }

        [Test]
        public void ToString_Edition_NameAndAuthors()
        {
            var warandpeace = CreateTestEdition();

            Assert.AreEqual("WarandPeace, Tolstoy", warandpeace.ToString());

        }

        private Edition CreateTestEdition()
        {
            return new Edition("WarandPeace", "Tolstoy", 2010, "Eksmo", 001);
        }
    }
}
