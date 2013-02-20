using System;

class MinMaxAvrgSumWithVariableNumbers
{
    static long MinVariableNum(params int[] arr)
    {
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (min > arr[i])
            {
                min = arr[i];
            }
        }
        return min;
    }

    static long MaxVariableNum(params int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (max < arr[i])
            {
                max = arr[i];
            }
        }
        return max;
    }

    static long SumVariableNum(params int[] arr)
    {
        long sum = 0;
        foreach (var element in arr)
        {
            sum += element;
        }
        return sum;
    }

    static decimal AvrgVariableNum(params int[] arr)
    {        
        return (decimal)SumVariableNum(arr) / arr.Length;
    }

    static void Main()
    {
        Console.WriteLine(MinVariableNum(1, 2, 3, 4, 5, 6, 7, 8));
        Console.WriteLine(MaxVariableNum(1, 2, 3, 4, 5, 6, 7, 8));
        Console.WriteLine(SumVariableNum(1, 2, 3, 4, 5, 6, 7, 8));
        Console.WriteLine(AvrgVariableNum(1, 2, 3, 4, 5, 6, 7, 8));
    }
}

