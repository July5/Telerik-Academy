using System;

class MaximalSumOfKElementInArrayWithLengthN
{
    static void Main()
    {
        Console.Write("Enter lenght N of the array: ");
        int lengthN = int.Parse(Console.ReadLine());
        int[] arr = new int[lengthN];
        Console.Write("Enter K: ");
        int numberK = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter elements for the array:");
        for (int i = 0; i < lengthN; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int sum = 0;
        int bestSum = 0;
        for (int i = 0; i < (lengthN - numberK + 1); i++)
        {
            for (int k = i; k < (i + numberK); k++)
            {
                sum += arr[k];
            }
            if (bestSum < sum)
            {
                bestSum = sum;
            }
            sum = 0;
        }
        Console.WriteLine("Maximal sum of K element in the array is: {0}", bestSum);
    }
}

