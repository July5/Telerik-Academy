using System;

class CompareTwoArraysElementByElement
{
    static void Main()
    {
        Console.Write("Enter lenght of the two arrays: ");
        int lengthArr = int.Parse(Console.ReadLine());
        int[] arr1 = new int[lengthArr];
        int[] arr2 = new int[lengthArr];
        Console.WriteLine("Enter elements for the first array:");
        for (int i = 0; i < lengthArr; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter elements for the second array:");
        for (int i = 0; i < lengthArr; i++)
        {
            arr2[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < lengthArr; i++)
        {
            Console.Write("Compare elements with index {0}: ", i);
            if (arr1[i] > arr2[i])
            {
                Console.WriteLine("The element from first array is bigger.");
            }
            else if (arr1[i] == arr2[i])
            {
                Console.WriteLine("Elements are equal.");
            }
            else
            {
                Console.WriteLine("The element from second array is bigger.");
            }
        }
    }
}

