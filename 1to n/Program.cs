using System;
using System.Text;
class Program
{
    static void Main()
    {
        Console.Write("Enter a positive number: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        int sumLoop = 0;
        for (int i = 1; i <= n; i++)
            sumLoop += i;
        int sumFormula = n * (n + 1) / 2;
        Console.WriteLine($"Sum using loop: {sumLoop}");
        Console.WriteLine($"Sum using formula: {sumFormula}");
        Console.Write("Numbers: ");
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i);
            if (i < n) Console.Write(", ");
        }
        StringBuilder sb = new StringBuilder();
        for (int i = 1; i <= n; i++)
        {
            sb.Append(i);
            if (i < n) sb.Append(", ");
        }
        Console.WriteLine("\nUsing StringBuilder: " + sb.ToString());
    }
}
