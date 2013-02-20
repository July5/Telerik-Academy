using System;

class SortArrayAndFindLargesNumberLessOrEqualToK
{
    static void Main()
    {
        Console.Write("Enter array with length N: ");
        int numberN = int.Parse(Console.ReadLine());
        int[] arr = new int[numberN];
        Console.WriteLine("Enter element of the array:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter number K: ");
        int numberK = int.Parse(Console.ReadLine());
        Array.Sort(arr);
        if (arr[0] > numberK)
        {
            Console.WriteLine("All numbers in the given array are bigger than K!");
        }
        else
        {
            int indexK = Array.BinarySearch(arr, numberK);           
            while (indexK < 0)
            {
                numberK--;
                indexK = Array.BinarySearch(arr, numberK);
            }
            Console.WriteLine("The biggest number <= K is: {0}", arr[indexK]);            
        } 

    }
}

