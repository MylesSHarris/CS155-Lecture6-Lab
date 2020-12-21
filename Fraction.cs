using System;
namespace Lab
{
    public class Fraction
    {
        private double numerator, denominator;

        public Fraction(double numerator, double denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public double Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        public double Denominator
        {
            get { return denominator; }
            set { denominator = value; }
        }

        private int FindGreatestCommonDenominator()
        {
            int greatest = 1;
            for (int i = 1; i <= Math.Max(numerator, denominator); i++)
            {
                if (numerator % i == 0 && denominator % i == 0) greatest = i;
            }
            return greatest;
        }

        public void PrintReduced()
        {
            int greatestCommonDenominator = FindGreatestCommonDenominator();
            Console.WriteLine($"{numerator / greatestCommonDenominator} / {denominator / greatestCommonDenominator}");
        }
    }
}
