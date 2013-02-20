using System;

class BiggesElementInArrayAndSortingArray
{
    static int BiggestElementInPArtOFArray(int[] arr, int start, int length)
    {
        int biggestIndex = start;
        for (int i = start; i < length-1; i++)
        {
            if (arr[i] < arr[i+1])
            {
                biggestIndex = i + 1;
            }
        }
        return biggestIndex;
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
        for (int i = 0, index = 0, exchange = 0; i < arr.Length; i++)
        {
            index = BiggestElementInPArtOFArray(arr, i, arr.Length);
            exchange = arr[i];
            arr[i] = arr[index];
            arr[index] = exchange;
        }
        Console.Write("The array sorted in the descending order: ");
        foreach (var element in arr)
        {
            Console.Write("{0} ", element);
        }
        Console.WriteLine();
        for (int i = (arr.Length - 1), index = 0, exchange = 0; i >= 0; i--)
        {
            index = BiggestElementInPArtOFArray(arr, i, arr.Length);
            exchange = arr[i];
            arr[i] = arr[index];
            arr[index] = exchange;
        }
        Console.Write("The array sorted in the ascending order: ");
        foreach (var element in arr)
        {
            Console.Write("{0} ",element);
        }
        Console.WriteLine();
    }
}

