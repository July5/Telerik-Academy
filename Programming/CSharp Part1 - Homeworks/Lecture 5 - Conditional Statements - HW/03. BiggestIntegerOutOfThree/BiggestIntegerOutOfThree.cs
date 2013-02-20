using System;

class BiggestIntegerOutOfThree
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int number2 = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int number3 = int.Parse(Console.ReadLine());
        int biggestNumber = 0;
        if (number1 > number2)
        {
            if (number1 > number3)
            {
                biggestNumber = number1;
            }
            else
            {
                biggestNumber = number3;
            }
        }
        else
        {
            if (number2 > number3)
            {
                biggestNumber = number2;
            }
            else
            {
                biggestNumber = number3;
            }
        }
        Console.WriteLine("The biggest number is: {0}", biggestNumber);
    }
}

