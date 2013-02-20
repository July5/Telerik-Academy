using System;

class QuickSortAlgorithmForArray
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
        QuickSortArray(arr, 0, (arr.Length - 1));
        Console.WriteLine("Sorted array:");
        for (int i = 0; i < lengthArr; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }

    static int Partition(int[] arr, int small, int big)
    {
        int exChange;
        int x = arr[big];
        int i = small - 1;
        for (int j = small; j <= big - 1; j++)
        {
            if (arr[j] <= x)
            {
                i++;
                exChange = arr[i];
                arr[i] = arr[j];
                arr[j] = exChange;
            }
        }
        exChange = arr[i + 1];
        arr[i + 1] = arr[big];
        arr[big] = exChange;
        return i + 1;
    }	

    static void QuickSortArray (int[] arr, int small, int big)
    {
        int i;
        if (small < big)
        {
            i = Partition(arr, small, big);
            QuickSortArray(arr, small, i - 1);
            QuickSortArray(arr, i + 1, big);
        }
 
    }
}

