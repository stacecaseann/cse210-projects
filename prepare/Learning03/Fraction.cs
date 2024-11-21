public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _denominator = 1;
        _numerator = 1;
    }
    public Fraction(int numerator, int denominator)
    {
        _denominator = denominator;
        _numerator = numerator;
    }
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }
    public int GetNumerator()
    {
        return _numerator;
    }
    public int GetDenominator()
    {
        return _denominator;
    }
    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }
    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }

    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }
    public decimal GetDecimalValue()
    {
        decimal decimalValue = (decimal)_numerator/(decimal)_denominator;
        return decimalValue;
    }
}