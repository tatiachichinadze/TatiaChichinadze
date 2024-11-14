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
        var denominator = LCM(fraction1._denominator, fraction2._denominator);

        var numerator = (denominator / fraction1._denominator * fraction1._numerator) +
                        (denominator / fraction2._denominator * fraction2._numerator);

        var gcd = GCD(denominator, numerator);

        return new Fraction(numerator / gcd, denominator / gcd);
    }

    public static bool operator ==(Fraction fraction1, Fraction fraction2)
    {
        return (fraction1._numerator == fraction2._numerator) &&
               (fraction1._denominator == fraction2._denominator);
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

    public override bool Equals(object obj)
    {
        if (obj is Fraction fraction)
        {
            return this == fraction;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return _numerator.GetHashCode() ^ _denominator.GetHashCode();
    }
}

public class Program
{
    public static void Main()
    {
        var fraction1 = new Fraction(2, 8);
        var fraction2 = new Fraction(3, 6);

        var result = fraction1 + fraction2;

        Console.WriteLine(result.ToString());
    }
}

