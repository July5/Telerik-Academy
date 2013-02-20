using System;

class SortingArray
{
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
        int smallestElement;
        int exChange = 0;
        int position = 0;
        for (int i = 0; i < lengthArr; i++)
        {
            smallestElement = arr[i];
            for (int k = i; k < lengthArr; k++)
            {
                if (arr[k] <= smallestElement)
                {
                    smallestElement = arr[k];
                    position = k;
                }
            }
            if (arr[i] != smallestElement)
            {
                exChange = arr[i];
                arr[i] = arr[position];
                arr[position] = exChange;
            }
        }
        Console.WriteLine("The sorted array is:");
        for (int i = 0; i < lengthArr; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}

