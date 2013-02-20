using System;

class CompareTwoCharArraysLexicographically
{
    static void Main()
    {
        Console.Write("Enter lenght of the two arrays: ");
        int lengthArr = int.Parse(Console.ReadLine());
        char[] arr1 = new char[lengthArr];
        char[] arr2 = new char[lengthArr];
        Console.WriteLine("Enter letters for the first array:");
        for (int i = 0; i < lengthArr; i++)
        {
            arr1[i] = char.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter letters for the second array:");
        for (int i = 0; i < lengthArr; i++)
        {
            arr2[i] = char.Parse(Console.ReadLine());
        }
        for (int i = 0; i < lengthArr; i++)
        {
            Console.Write("Compare letters from two arrays with index {0}: ", i);
            if (arr1[i] == arr2[i])
            {
                Console.WriteLine("Letters are identical.");
            }
            else
            {
                Console.WriteLine("Letters are not identical.");
            }
        }
    }
}

