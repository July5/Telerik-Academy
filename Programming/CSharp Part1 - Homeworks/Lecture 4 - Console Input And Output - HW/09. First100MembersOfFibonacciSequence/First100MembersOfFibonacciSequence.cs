using System;
class First100MembersOfFibonacciSequence
{
    static void Main()
    {
        decimal number1 = 0;
        decimal number2 = 1;
        decimal helper;
        Console.WriteLine("{0,21}; ", 0);
        for (int i = 1; i <100; i++)
        {
            Console.WriteLine("{0,21}; ", number2);
            helper = number2;
            number2 += number1;
            number1 = helper;
        }
    }
}

