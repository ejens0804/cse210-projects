using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(3, 4);

        f1.GetFractionString();
        f1.GetTop();
        f2.SetTop(5);
        f2.GetFractionString();
        f2.GetTop();
        f3.GetFractionString();
        f3.GetDecimalValue();
        f3.SetTop(1);
        f3.SetBottom(3);
        f3.GetFractionString();
        f3.GetDecimalValue();
    }
}