using System;
using System.Collections.Generic;

class FindingSequenceOfGivenSunInArray
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
        Console.Write("Enter sum S: ");
        int sumS = int.Parse(Console.ReadLine());
        int currentSum = 0;
        int count = 0;
        for (int i = 0; i < lengthArr; i++)
        {
            List<int> listArr = new List<int>();
            for (int k = i; (k < lengthArr) && (sumS > currentSum); k++)
            {
                currentSum += arr[k];
                listArr.Add(arr[k]);
                count++;
            }
            if (sumS == currentSum)
            {
                Console.Write("Sequence sum equal to S: ");
                for (int j = 0; j < count; j++)
                {
                    Console.Write(listArr[j] + " ");
                }
                Console.WriteLine();
            }
            count = 0;
            currentSum = 0;
        }
    }
}

