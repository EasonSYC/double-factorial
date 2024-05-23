internal class Program
{
    static ulong DoubleFactorial(uint n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        return n * DoubleFactorial(n - 2);
    }
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        string input = Console.ReadLine() ?? string.Empty;
        uint n = uint.Parse(input);
        Console.WriteLine("Double Factorial = " + DoubleFactorial(n));
    }
}