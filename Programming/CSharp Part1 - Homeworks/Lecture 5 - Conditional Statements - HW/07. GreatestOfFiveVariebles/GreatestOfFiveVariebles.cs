using System;

class GreatestOfFiveVariebles
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int number2 = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int number3 = int.Parse(Console.ReadLine());
        Console.Write("Enter fourth number: ");
        int number4 = int.Parse(Console.ReadLine());
        Console.Write("Enter fifth number: ");
        int number5 = int.Parse(Console.ReadLine());
        int greatestNumber = 0;
        if ((number1 > number2) && (number1 > number3) && (number1 > number4) && (number1 > number5))
        {
            greatestNumber = number1;
        }
        if ((number2 >= number1) && (number2 >= number3) && (number2 >= number4) && (number2 >= number5))
        {
            greatestNumber = number2;
        }
        if ((number3 >= number2) && (number3 >= number1) && (number3 >= number4) && (number3 >= number5))
        {
            greatestNumber = number3;
        }
        if ((number4 >= number2) && (number4 >= number3) && (number4 >= number1) && (number4 >= number5))
        {
            greatestNumber = number4;
        }
        if ((number5 >= number2) && (number5 >= number3) && (number5 >= number4) && (number5 >= number1))
        {
            greatestNumber = number5;
        }
        Console.WriteLine("The greatest number is: {0}", greatestNumber);
    }
}

