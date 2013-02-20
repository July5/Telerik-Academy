using System;

class NumbersInGivenRange
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter 10 numbers in range [1..100]");
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = ReadNumber(1, 100);
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("The last number is not in the requered range!");
        }

    }

    static int ReadNumber(int start, int end)
    {
        int number = int.Parse(Console.ReadLine());
        if ((number < start) || (number > end))
        {
            throw new ArgumentOutOfRangeException();
        }
        return number;
    }
}

