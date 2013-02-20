using System;

class MaxIntegerOfThree
{
    static int GetMax(int number1, int number2)
    {
        if (number1 > number2)
        {
            return number1;      
        }
        else
        {
            return number2;
        }
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int number2 = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int number3 = int.Parse(Console.ReadLine());
        int maxNumber;
        maxNumber = GetMax(GetMax(number1, number2), number3);
        Console.WriteLine("The biggest number is: {0}",maxNumber);
    }
}