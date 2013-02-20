using System;

class MaximalSequenceOfEqualElementsInArray
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
        int count = 0;
        int start = 0;
        int bestStart = 0;
        int bestCount = 0;
        for (int i = 0; i < (lengthArr - 1); i++)
        {
            if (arr[i] == arr[i + 1])
            {
                start = i;
                count++;
                for (int j = i+1; j < (lengthArr - 1); j++)
                {
                    if (arr[j] == arr[j+1])
                    {
                        count++;
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }                
            }
            if (bestCount <= count)
            {
                if (bestCount == count)
                {
                    
                }
                bestCount = count;
                bestStart = start;
            }
            count = 0;
        }
        Console.Write("The maximal sequance of equal elements is: ");
        for (int i = bestStart; i <= bestStart + bestCount; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
