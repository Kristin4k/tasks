using NUnit.Framework;
using System;
using Complex;


namespace Complex
{
    [TestFixture]
    public class ComplexTests
    {
        [Test]
        public void ConstructorTest()
        {
            var complex = new Complex(2, 5);

            Assert.That(complex.Re, Is.EqualTo(2));
            Assert.That(complex.Im, Is.EqualTo(5));
            Assert.That(complex.Abs, Is.EqualTo(Math.Sqrt(29)));
        }

        [Test]
        public void ToStringTest()
        {
            var complex1 = new Complex(2, 1);
            var complex2 = new Complex(2, -1);
            var complex3 = new Complex(0, 0);
            var complex4 = new Complex(0, 5);
            var complex5 = new Complex(2, 0);
            var complex6 = new Complex(2, -5);
            var complex7 = new Complex(2, 5);


            Assert.That(complex1.ToString(), Is.EqualTo("2 + i"));
            Assert.That(complex2.ToString(), Is.EqualTo("2 - i"));
            Assert.That(complex3.ToString(), Is.EqualTo("0"));
            Assert.That(complex4.ToString(), Is.EqualTo("5i"));
            Assert.That(complex5.ToString(), Is.EqualTo("2"));
            Assert.That(complex6.ToString(), Is.EqualTo("2 - 5i"));
            Assert.That(complex7.ToString(), Is.EqualTo("2 + 5i"));
        }

        [Test]
        public void EqualsTest()
        {
            var complex1 = new Complex(2, 5);
            var complex2 = new Complex(2, 5);
            var complex3 = new Complex(3, -4);

            Assert.That(complex1.Equals(complex2));
            Assert.That(!complex1.Equals(complex3));
        }

        [Test]
        public void OperationsTest()
        {
            var complex1 = new Complex(2, 5);
            var complex2 = new Complex(2, 5);
            var complex3 = new Complex(3, -4);

            Assert.That(complex1 == complex2);
            Assert.That(complex1 != complex3);
            Assert.That(~complex1 == new Complex(2, -5));
            Assert.That(complex1 * complex3 == new Complex(2 * 3 - 5 * (-4), 2 * (-4) + 5 * 3));
            Assert.That(complex1 / complex3 == complex1 * new Complex((3 / (complex3.Abs) * (complex3.Abs)), (4 / (complex3.Abs) * (complex3.Abs))));
        }

    }
}