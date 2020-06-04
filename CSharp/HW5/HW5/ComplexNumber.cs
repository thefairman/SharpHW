using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Complex
    {
        double real, imaginary;
        public Complex(double real = 0, double imaginary = 0)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public static bool operator ==(Complex a, Complex b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Complex a, Complex b)
        {
            return !a.Equals(b);
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex { imaginary = a.imaginary + b.imaginary, real = a.real + b.real };
        }

        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex { imaginary = a.imaginary - b.imaginary, real = a.real - b.real };
        }

        public static Complex operator -(Complex a, double d)
        {
            return a - new Complex(d, 0);
        }

        public static Complex operator -(double d, Complex b)
        {
            return new Complex(d, 0) - b;
        }

        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex
            {
                real = a.real * b.real - a.imaginary * b.imaginary,
                imaginary = a.imaginary * b.real + a.real * b.imaginary
            };
        }
        
        public static Complex operator *(Complex a, double d)
        {
            return a * new Complex(d, 0);
        }

        public static Complex operator *(double d, Complex b)
        {
            return new Complex(d, 0) * b;
        }

        public static Complex operator /(Complex a, Complex b)
        {
            return new Complex
            {
                real = (a.real * b.real + a.imaginary * b.imaginary) / (b.real * b.real + b.imaginary * b.imaginary),
                imaginary = (a.imaginary * b.real - a.real * b.imaginary) / (b.real * b.real + b.imaginary * b.imaginary)
            };
        }

        public override bool Equals(object obj)
        {
            return obj is Complex complex &&
                   real == complex.real &&
                   imaginary == complex.imaginary;
        }

        public override int GetHashCode()
        {
            int hashCode = -1613305685;
            hashCode = hashCode * -1521134295 + real.GetHashCode();
            hashCode = hashCode * -1521134295 + imaginary.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"{real:0.####} + {imaginary:0.####}i";
        }
    }
}
