public class Fraction
{
    // Member Variables / Attributes
    private int _top;
    private int _bottom;

    // Constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int topNumber, int bottomNumber)
    {
        _top = topNumber;
        _bottom = bottomNumber;
    }

    // Member Functions / Methods
    // Getter and setter functions (accessors and mutators)
    public void GetTop()
    {
        Console.WriteLine(_top);
    }

    public void SetTop(int topNumber)
    {
        // Console.Write("Input a whole number to set the numerator: ");
        // _top = int.Parse(Console.ReadLine());

        _top = topNumber;
    }

    public void GetBottom()
    {
        Console.WriteLine(_bottom);
    }

    public void SetBottom(int bottomNumber)
    {
        // Console.Write("Input a whole number to set the denominator: ");
        // _bottom = int.Parse(Console.ReadLine());

        _bottom = bottomNumber;
    }


    public void GetFractionString()
    {
        // if (_top == 1 && _bottom == 1)
        // {
        //     Console.WriteLine("1");
        // }
        // else if (_bottom == 1)
        // {
        //     Console.WriteLine($"{_top}");
        // }
        Console.WriteLine($"{_top}/{_bottom}");
    }

    public void GetDecimalValue()
    {
        double decimalValue = (double)_top / (double)_bottom;
        Console.WriteLine($"{decimalValue}");
    }
}