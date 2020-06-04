using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Fraction
    {
        int ch, zn;
        public Fraction(int numerator = 0, int denomination = 1)
        {
            ch = numerator;
            zn = denomination;
        }

        public override bool Equals(object obj)
        {
            return obj is Fraction fraction &&
                   ch * fraction.zn == fraction.ch * zn;
        }

        public override int GetHashCode()
        {
            int hashCode = 2111653239;
            hashCode = hashCode * -1521134295 + ch.GetHashCode();
            hashCode = hashCode * -1521134295 + zn.GetHashCode();
            return hashCode;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction
            {
                ch = a.ch * b.zn + b.ch * a.zn,
                zn = a.zn * b.zn
            };
        }

        public static Fraction operator +(Fraction a, double d)
        {
            return a + FromDoubleToFraction(d);
        }

        public static Fraction operator +(double d, Fraction b)
        {
            return FromDoubleToFraction(d) + b;
        }

        public static Fraction FromDoubleToFraction(double real, int precision = 0)
        {
            int razr = 1;
            for (int i = 0; real % 1 != 0 && (i < precision || precision == 0); i++)
            {
                real *= 10;
                razr *= 10;
            }
            return new Fraction((int)real, razr);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction
            {
                ch = a.ch * b.zn - b.ch * a.zn,
                zn = a.zn * b.zn
            };
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction
            {
                ch = a.ch * b.ch,
                zn = a.zn * b.zn
            };
        }

        public static Fraction operator *(Fraction a, int i)
        {
            return a * new Fraction(i, 1);
        }

        public static Fraction operator *(int i, Fraction b)
        {
            return new Fraction(i, 1) * b;
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            return new Fraction
            {
                ch = a.ch * b.zn,
                zn = a.zn * b.ch
            };
        }

        public static bool operator ==(Fraction a, Fraction b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            return !a.Equals(b);
        }

        public static bool operator >(Fraction a, Fraction b)
        {
            return a.ch * b.zn > b.ch * a.zn;
        }

        public static bool operator <(Fraction a, Fraction b)
        {
            return a.ch * b.zn < b.ch * a.zn;
        }

        public static bool operator true (Fraction a)
        {
            return a.ch > a.zn;
        }

        public static bool operator false(Fraction a)
        {
            return a.ch <= a.zn;
        }

        public override string ToString()
        {
            return ch < zn ? $"{ch}/{zn}" : $"{ch / zn}+{ch % zn}/{zn}";
        }
    }
}
