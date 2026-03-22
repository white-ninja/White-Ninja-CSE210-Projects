// A class to represent a fraction with a numerator and denominator
public class Fraction
{
    private int _top;
    private int _bottom;

// No parameter constructor → 1/1
    public Fraction()
{
    _top = 1;
    _bottom = 1;
}

// One parameter constructor → top/1
public Fraction(int wholeNumber)
{
    _top = wholeNumber;
    _bottom = 1;
}

// Two parameters constructor → top/bottom
public Fraction(int top, int bottom)
{
    _top = top;
    _bottom = bottom;
}

// Getters and setters for the top and bottom of the fraction
public int GetTop()
{
    return _top;
}

public void SetTop(int top)
{
    _top = top;
}

public int GetBottom()
{
    return _bottom;
}

public void SetBottom(int bottom)
{
    _bottom = bottom;
}

// Method to return the fraction as a string in the form "top/bottom"
public string GetFractionString()
{
    return $"{_top}/{_bottom}";
}

// Method to return the decimal value of the fraction
public double GetDecimalValue()
{
    return (double)_top / _bottom;
}

}

