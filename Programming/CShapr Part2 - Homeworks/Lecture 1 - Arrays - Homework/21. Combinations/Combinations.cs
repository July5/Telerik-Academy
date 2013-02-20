using System;

class Combinations
{
   
    static void Main()
    {
        Console.Write("Enter K: ");
        int numberK = int.Parse(Console.ReadLine());
        Console.Write("Enter N: ");
        int numberN = int.Parse(Console.ReadLine());
        int[] arr = new int[numberK];
        Combination(numberK - 1, numberN, arr, 1);
    }

    static void PrintResult(int[] arr)
    {
        foreach (var element in arr)
        {
            Console.Write("{0} ", element);
        }
        Console.WriteLine();
    }

    static void Combination(int index, int lenght, int[] arr, int start)
    {
        if (index == -1)
        {
            PrintResult(arr);
        }
        else
        {
            for (int i = start; i <= lenght; i++)
            {
                arr[index] = i;
                Combination(index - 1, lenght, arr, i+1);
            }
        }
    }
}
    
