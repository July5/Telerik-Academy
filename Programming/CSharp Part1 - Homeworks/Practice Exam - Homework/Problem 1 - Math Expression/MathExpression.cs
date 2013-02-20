using System;

class MathExpression
{
    static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());
        decimal m = decimal.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());
        decimal result = ((((n * n) + (1 / (m * p)) + 1337m) / (n - (128.523123123m * p))) + (decimal)Math.Sin((int)m % 180));
        Console.WriteLine("{0:0.000000}", result);
    }
}

