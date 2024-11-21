using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction first = new Fraction();
        Console.WriteLine(first.GetFractionString());
        Fraction second = new Fraction(6);
        Console.WriteLine(second.GetFractionString());
        Fraction third = new Fraction(3,4);
        Console.WriteLine(third.GetFractionString());

        third.SetNumerator(5);
        third.SetDenominator(6);
        
        Console.WriteLine(third.GetFractionString());
        int numerator = third.GetNumerator();
        int denominator = third.GetDenominator();
        Console.WriteLine(numerator);
        Console.WriteLine(denominator);

        Console.WriteLine(third.GetFractionString());
        Console.WriteLine(third.GetDecimalValue());

    }
}