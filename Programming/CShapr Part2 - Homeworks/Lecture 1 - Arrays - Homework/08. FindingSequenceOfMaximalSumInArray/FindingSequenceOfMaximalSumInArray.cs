using System;

class FindingSequenceOfMaximalSumInArray
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
        int sum = 0;
        int bestSum = 0;
        int sumStart = 0;
        int sumEnd = 0;
        for (int i = 0; i < lengthArr; i++)
        {
            sum = arr[i];
            for (int k = i+1; k < lengthArr; k++)
            {
                sum += arr[k];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    sumStart = i;
                    sumEnd = k;
                }
            }
        }

        Console.Write("Sequance of maximal sum in given array is: ");
        for (int i = sumStart; i <= sumEnd; i++)
        {
            Console.Write(arr[i] +" ");
        }
        Console.WriteLine();
    }
}

