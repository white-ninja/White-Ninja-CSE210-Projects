using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        // Create some fractions using the different constructors
        Fraction frac1 = new Fraction();
        Fraction frac2 = new Fraction(5);
        Fraction frac3 = new Fraction(3, 4);
        Fraction frac4 = new Fraction(1, 3);
        // Test Getters & Setters (Important!)
        frac3.SetTop(10);
        frac3.SetBottom(2);

        // Display the fractions and their decimal values
        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetDecimalValue());

        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac2.GetDecimalValue());

        Console.WriteLine(frac3.GetFractionString());
        Console.WriteLine(frac3.GetDecimalValue());

        Console.WriteLine(frac4.GetFractionString());
        Console.WriteLine(frac4.GetDecimalValue());
        // Output for frac3 after using setters
        Console.WriteLine(frac3.GetFractionString()); // 10/2
        Console.WriteLine(frac3.GetDecimalValue()); // 5.0
    }
}