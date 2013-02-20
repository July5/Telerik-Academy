using System;

class MostFrequentNumberInArray
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
        int bestCount = 0;
        int position = 0;
        for (int i = 0; i < lengthArr; i++)
        {
            if (arr[i] != int.MinValue)
            {

                for (int k = (i + 1); k < lengthArr; k++)
                {
                    if (arr[i] == arr[k])
                    {
                        count++;
                        arr[k] = int.MinValue;
                    }
                }
                if (bestCount < count)
                {
                    bestCount = count;
                    position = i;
                }
                count = 0;
            }
        }
        Console.WriteLine("Most frequen number in the given array is: {0}", arr[position]);
    }
}

