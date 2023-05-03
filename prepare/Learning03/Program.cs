using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate three new Fraction objects.
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(3);
        Fraction fraction3 = new Fraction(3, 4);

        // Declare variables that will contain corresponding values.
        int top;
        int bottom;
        string fractionString;
        double decimalValue;

        // Initialize values for fraction1.
        top = fraction1.GetTop();
        bottom = fraction1.GetBottom();
        fractionString = fraction1.GetFractionString();
        decimalValue = fraction1.GetDecimalValue();

        // Print out fraction1 values to the console.
        Console.WriteLine(top);
        Console.WriteLine(bottom);
        Console.WriteLine(fractionString);
        Console.WriteLine(decimalValue);
        Console.WriteLine();

        // Initialize values for fraction2.
        top = fraction2.GetTop();
        bottom = fraction2.GetBottom();
        fractionString = fraction2.GetFractionString();
        decimalValue = fraction2.GetDecimalValue();

        // Print out fraction2 values to the console.
        Console.WriteLine(top);
        Console.WriteLine(bottom);
        Console.WriteLine(fractionString);
        Console.WriteLine(decimalValue);
        Console.WriteLine();

        // Initialize values for fraction3.
        top = fraction3.GetTop();
        bottom = fraction3.GetBottom();
        fractionString = fraction3.GetFractionString();
        decimalValue = fraction3.GetDecimalValue();

        // Print out fraction3 values to the console.
        Console.WriteLine(top);
        Console.WriteLine(bottom);
        Console.WriteLine(fractionString);
        Console.WriteLine(decimalValue);
        Console.WriteLine();
    }
}