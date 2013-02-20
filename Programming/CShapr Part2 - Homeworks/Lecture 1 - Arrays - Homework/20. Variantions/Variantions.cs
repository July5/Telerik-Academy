using System;

class Variantions
{
    static void Main()
    {
        Console.Write("Enter K: ");
        int numberK = int.Parse(Console.ReadLine());
        Console.Write("Enter N: ");
        int numberN = int.Parse(Console.ReadLine());
        int[] arr = new int[numberK];
        Variantion(numberK - 1, numberN, arr);
    }

    static void PrintResult(int[] arr)
    {
        foreach (var element in arr)
        {
            Console.Write("{0} ", element);
        }
        Console.WriteLine();
    }

    static void Variantion(int index, int lenght, int[] arr)
    {
        if (index == -1)
        {
            PrintResult(arr);
        }
        else
        {
            for (int i = 1; i <= lenght; i++)
            {
                arr[index] = i;
                Variantion(index - 1, lenght, arr);
            }
        }
    }
}