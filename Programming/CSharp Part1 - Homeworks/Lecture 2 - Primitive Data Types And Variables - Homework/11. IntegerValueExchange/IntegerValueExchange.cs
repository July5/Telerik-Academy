using System;

class IntegerValueExchange
{
    static void Main()
    {
        int number1 = 5;
        int number2 = 10;
        Console.WriteLine("Numbers before exchange");
        Console.WriteLine(number1);
        Console.WriteLine(number2);
        int exchangeHelper = number1;
        number1 = number2;
        number2 = exchangeHelper;
        Console.WriteLine("Numbers after exchange");
        Console.WriteLine(number1);
        Console.WriteLine(number2);
    }
}

