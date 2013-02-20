using System;

public class IfElementOfArrayIsBiggerThanNaighbors
{
    public static string IfElementBiggerThanNeigbors(int index, int[] arr)
    {
        if (index == 0)
        {
            if (arr[0] > arr[1])
            {
                return "True";
            }
            else
            {
                return "False";
            }
        }
        else if (index == (arr.Length-1))
        {
            if (arr[arr.Length-1] > arr[arr.Length-2])
            {
                return "True";
            }
            else
            {
                return "False";
            }
        }
        else if ((arr[index] > arr[index+1]) && (arr[index] > arr[index-1]))
        {
            return "True";
        }
        else
        {
            return "False";
        }
    }
    static void Main()
    {
        int[] arr = new int[]{1,2,3,2,6,7,6,5};
        Console.WriteLine(IfElementBiggerThanNeigbors(5,arr));
    }
}

