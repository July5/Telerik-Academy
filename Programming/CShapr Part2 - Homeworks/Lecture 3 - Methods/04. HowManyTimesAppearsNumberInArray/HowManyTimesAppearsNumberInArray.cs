using System;

class HowManyTimesAppearsNumberInArray
{
    static void CountNumberInArray(int number, int[] arr)
    {
        int count = 0;
        foreach (int element in arr)
        {
            if (element == number)
            {
                count++;
            }
        }
        Console.WriteLine("The number {0}, exist {1} times in the given array.", number, count);
    }

    static void Main()
    {
        Console.Write("Enter lenght of the array: ");
        int lengthArr = int.Parse(Console.ReadLine());
        int[] arr = new int[lengthArr];
        Console.WriteLine("Enter elements for the array:");
        for (int i = 0; i < lengthArr; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter number to search in the array: ");
        int number = int.Parse(Console.ReadLine());
        CountNumberInArray(number, arr);
    }
}

