using System;

namespace exercise4_fraction
{
    public class Calculation
    {
        public Fraction First { get; set; }
        public Fraction Second { get; set; }
        public Fraction Result { get; set; }

        public Calculation(Fraction first, Fraction second)
        {
            First = first;
            Second = second;
        }

        private int GCD(Fraction fraction)
        {
            int numerator = fraction.Numerator;
            int denominator = fraction.Denominator;

            while (denominator != 0)
            {
                int temp = denominator;
                denominator = numerator % denominator;
                numerator = temp;
            }

            return numerator;
        }

        public void Calculate(char @operator)
        {
            int numerator = 0, denominator = 0;
            switch (@operator)
            {
                case '+':
                {
                    numerator = First.Numerator * Second.Denominator + Second.Numerator * First.Denominator;
                    denominator = First.Denominator * Second.Denominator;
                    break;
                }
                case '-':
                {
                    numerator = First.Numerator * Second.Denominator - Second.Numerator * First.Denominator;
                    denominator = First.Denominator * Second.Denominator;
                    break;
                }
                case '*':
                {
                    numerator = First.Numerator * Second.Numerator;
                    denominator = First.Denominator * Second.Denominator;
                    break;
                }
                case '/':
                {
                    numerator = First.Numerator * Second.Denominator;
                    denominator = First.Denominator * Second.Numerator;
                    break;
                }
            }
            
            Result = new Fraction(numerator, denominator);
        }

        public Fraction Normalized(Fraction fraction)
        {
            int x = GCD(fraction);
            return new Fraction((fraction.Numerator /= x), (fraction.Denominator /= x));
        }
    }
}