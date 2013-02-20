using System;

class FindInderOfElementInArrayWithBinarySearch
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
        Array.Sort(arr);
        Console.Write("Enter number for search in the array: ");
        int searchedNumber = int.Parse(Console.ReadLine());
        int minIndex = 0;
        int maxIndex = arr.Length - 1;
        int middlePoind = 0;
        while (minIndex <= maxIndex)
        {
            middlePoind = (maxIndex + minIndex) / 2;
            if (arr[middlePoind] < searchedNumber)
            {
                minIndex = middlePoind + 1;
            }
            else if (arr[middlePoind] > searchedNumber)
            {
                maxIndex = middlePoind - 1;
            }
            else 
            {
                Console.WriteLine("The index of the number in the given array, after sorting is: {0}", middlePoind);
                break;
            }
        }

    }
}

