using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulation.RationalNumbers
{
    public class Rational
    {
        private int _numerator;
        private int _denominator;

        public int Numerator
        {
            get => _numerator;
            set => _numerator = value;
        }

        public int Denominator
        {
            get => _denominator;
            set => _denominator = value;
        }

        public Rational(int numenator, int denominator = 0)
        {
            this.Numerator = numenator;
            this.Denominator = denominator;
        }

        public bool IsNan
        {
            get
            {
                if (this._denominator == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static Rational operator +(Rational a, Rational b)
        {
            int newNumerator = a.Numerator + b.Numerator;
            return new Rational(newNumerator, b.Denominator);
        }

        public static Rational operator -(Rational a, Rational b)
        {
            int newNumerator = a.Numerator - b.Numerator;
            return new Rational(newNumerator, b.Denominator);
        }

        public static Rational operator *(Rational a, Rational b)
        {
            int newNumerator = a.Numerator * b.Numerator;
            int newDenominator = a.Denominator * b.Denominator;
            return new Rational(newNumerator, newDenominator);
        }

        public static Rational operator /(Rational a, Rational b)
        {
            int newNumerator = a.Numerator * b.Denominator;
            int newDenominator = a.Denominator * b.Numerator;
            return new Rational(newNumerator, newDenominator);
        }

        public static implicit operator double(Rational a)
        {
            return a.Numerator / a.Denominator;
        }

        public static implicit operator Rational(int a)
        {
            return new Rational(a);
        }
    }
}