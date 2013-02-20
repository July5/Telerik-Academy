using System;

class CompareNumbersWithPrecision
{
    static void Main()
    {
        Console.WriteLine("Write first number:");
        decimal number1 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Write second number:");
        decimal number2 = decimal.Parse(Console.ReadLine());
        decimal result = (number1 - number2);
        if (result>=0.000001m || result<=-0.000001m)
        {
            Console.WriteLine("Numbers are NOT equal to  6 sign after decimal point.");
        }
        else
        {
            Console.WriteLine("Numbers are equal to 6 sign after decimal point.");
        }
    }
}

