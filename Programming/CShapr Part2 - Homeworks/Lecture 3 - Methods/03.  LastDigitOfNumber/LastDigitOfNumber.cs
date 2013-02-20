using System;

class LastDigitOfNumber
{
    static string LastDigitInEnglish(int number)
    {
        int lastNumber = number % 10;
        switch (lastNumber)
        {
            case 1:
                return "one";
            case 2:
                return "two";
            case 3:
                return "three";
            case 4:
                return "four";
            case 5:
                return "five";
            case 6:
                return "six";
            case 7:
                return "seven";
            case 8:
                return "eight";
            case 9:
                return "nine";
            case 0:
                return "ten";
            default:
                return "";                
        }
    }

    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The last digit is: {0}",LastDigitInEnglish(number));
    }
}

