using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    public struct Complex
    {
        public double Re { get; set; }
        public double Im { get; set; }
        public double Abs
        {
            get => Math.Sqrt(Re * Re + Im * Im);
        }

        public List<double> XY
        {
            get => new List<double> { Re, Im };
        }

        public Complex(double a, double b) : this()
        {
            Re = a;
            Im = b;
        }

        public override string ToString()
        {
            if (Im == 1) return $"{Re} + i";
            else if (Im == -1) return $"{Re} - i";
            else if (Re == 0 && Im == 0) return "0";
            else if (Re == 0) return $"{Im}i";
            else if (Im == 0) return $"{Re}";
            else if (Im < 0) return $"{Re} - {(-1)*Im}i";
            else return $"{Re} + {Im}i";
        }

        public override bool Equals(object obj)
        {
            if (obj is Complex)
                return Re == ((Complex)obj).Re && Im == ((Complex)obj).Im;

            throw new ArgumentException("Объект для сравнения не является комплексным числом");
        }

        public override int GetHashCode() => ToString().GetHashCode();

        public static bool operator ==(Complex a, Complex b) => a.Equals(b);
        public static bool operator !=(Complex a, Complex b) => !a.Equals(b);

        public static Complex operator ~(Complex a) => new Complex(a.Re, -1 * a.Im);
        public static Complex operator *(Complex a, Complex b) => new Complex((a.Re * b.Re - a.Im * b.Im), (a.Re * b.Im + a.Im * b.Re));
        public static Complex operator /(Complex z, Complex w)
        {
            if (w.Re != 0 && w.Im != 0)
            {
                var w1 = new Complex((~w).Re / (w.Abs) * (w.Abs), (~w).Im / (w.Abs) * (w.Abs));
                return z * w1;
            }
            else throw new ArgumentException("Делить на ноль нельзя!");
        }

    }
}
