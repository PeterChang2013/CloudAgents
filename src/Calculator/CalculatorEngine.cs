namespace Calculator;

public class CalculatorEngine
{
    private double _lastResult;

    public double LastResult => _lastResult;

    public double Add(double a, double b)
    {
        _lastResult = a + b;
        return _lastResult;
    }

    public double Subtract(double a, double b)
    {
        _lastResult = a - b;
        return _lastResult;
    }

    public double Multiply(double a, double b)
    {
        _lastResult = a * b;
        return _lastResult;
    }

    public double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero.");

        _lastResult = a / b;
        return _lastResult;
    }

    public double Power(double baseValue, double exponent)
    {
        _lastResult = Math.Pow(baseValue, exponent);
        return _lastResult;
    }

    public double SquareRoot(double value)
    {
        if (value < 0)
            throw new ArgumentException("Cannot calculate square root of a negative number.");

        _lastResult = Math.Sqrt(value);
        return _lastResult;
    }

    public double Modulo(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot perform modulo with zero.");

        _lastResult = a % b;
        return _lastResult;
    }

    public static bool TryParseOperation(string input, out string operation)
    {
        operation = input.Trim().ToLower();
        return operation is "+" or "-" or "*" or "/" or "%" or "pow" or "sqrt";
    }
}
