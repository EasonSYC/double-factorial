internal class Program
{
    static (string working, ulong number) DoubleFactorial(uint n)
    {
        if (n == 1)
        {
            return ("1", 1);
        }

        if (n == 2)
        {
            return ("2", 2);
        }
        (string working, ulong number) = DoubleFactorial(n - 2);
        return ($"{n} * " + working, n * number);
    }
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        string input = Console.ReadLine() ?? string.Empty;
        uint n = uint.Parse(input);
        if (n == 0)
        {
            Console.WriteLine("Double Factorial 0!! = 1");
        }
        else
        {
            (string working, ulong result) = DoubleFactorial(n);
            Console.WriteLine($"Double Factorial {n}!! = {working} = {result}.");
        }

    }
}