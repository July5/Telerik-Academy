using System;

class HowManyNumbersDevidedTo5
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int number2 = int.Parse(Console.ReadLine());
        int greaterNumber; 
        int smallerNumber;
        int count = 0;
        if (number1 > number2)
        {
            greaterNumber = number1;
            smallerNumber = number2;
        }
        else
        {
            greaterNumber = number2;
            smallerNumber = number1;

        }
        for (int i = smallerNumber; i <= greaterNumber; i += 5)
        {
            count++;
        }
        Console.WriteLine("Count of numbers that is devided to 5 between given two numbers are: {0}", count);
    }
}

