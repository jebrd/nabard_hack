using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Fibonacci Series Generator");
        Console.Write("Enter the number of terms to generate: ");

        if (!int.TryParse(Console.ReadLine(), out int terms) || terms < 1)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        Console.WriteLine($"First {terms} term(s) of the Fibonacci series:");
        for (int i = 0; i < terms; i++)
        {
            Console.WriteLine($"{i + 1}: {Fibonacci(i)}");
        }
    }

    static long Fibonacci(int n)
    {
        if (n < 0) throw new ArgumentOutOfRangeException(nameof(n));
        if (n == 0) return 0;
        if (n == 1) return 1;

        long a = 0;
        long b = 1;

        for (int i = 2; i <= n; i++)
        {
            long next = a + b;
            a = b;
            b = next;
        }

        return b;
    }
}
