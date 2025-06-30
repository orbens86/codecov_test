internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public static class MathUtils
{
    public static int Add(int a, int b) => a + b;

    public static int Subtract(int a, int b) => a - b;

    public static int Multiply(int a, int b) => a * b;

    public static int Divide(int a, int b)
    {
        if (b == 0) throw new DivideByZeroException("Cannot divide by zero");
        return a / b;
    }
}

public static class StringUtils
{
    public static string Reverse(string input)
    {
        if (string.IsNullOrEmpty(input)) return input;
        return new string(input.Reverse().ToArray());
    }

    public static bool IsPalindrome(string input)
    {
        var normalized = input.ToLowerInvariant().Replace(" ", "");
        return normalized == new string(normalized.Reverse().ToArray());
    }
}