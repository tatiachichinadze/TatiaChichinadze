using System;
using System.Text;

public class Fraction
{
    private int _numerator;
    private int _denominator;


    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new DivideByZeroException();

        _numerator = numerator;
        _denominator = denominator;
    }

    public override string ToString()
    {
        return $"{_numerator}/{_denominator}";
    }
    public static Fraction operator +(Fraction fraction1, Fraction fraction2)
    {
        //*აქ გამოვიყენე == ოპერატორის overload, ლოგიკური შეცდომაც გავასწორე */
        if (fraction1 == fraction2) 
        {
            return new Fraction(fraction1._numerator + fraction2._numerator, fraction1._denominator);
        }

        else
        {
            int denominator = LCM(fraction1._denominator, fraction2._denominator);
            int numerator = (denominator / fraction1._denominator * fraction1._numerator) +(denominator / fraction2._denominator * fraction2._numerator);
            int gcd = GCD(numerator, denominator);
            return new Fraction(numerator / gcd, denominator / gcd);
        }
    }

    public static bool operator ==(Fraction fraction1, Fraction fraction2)
    {
        return (fraction1._numerator == fraction2._numerator && fraction1._denominator == fraction2._denominator)
            || (fraction1._numerator / fraction1._denominator == fraction2._numerator / fraction2._denominator);

    }

    public static bool operator !=(Fraction fraction1, Fraction fraction2)
    {
        return !(fraction1 == fraction2);
    }

    private static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    private static int LCM(int a, int b)
    {
        return (a * b) / GCD(a, b);
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            var fraction1 = new Fraction(2, 5);
            var fraction2 = new Fraction(3, 5);
            var result = fraction1 + fraction2;

            Console.WriteLine(result.ToString());
        }
    }
}
