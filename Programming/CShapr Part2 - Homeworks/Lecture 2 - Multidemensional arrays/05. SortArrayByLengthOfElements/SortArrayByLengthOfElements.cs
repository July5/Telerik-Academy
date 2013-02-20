using System;

class SortArrayByLengthOfElements
{
    static void Main()
    {
        Console.Write("Enter lenght N of array: ");
        int N = int.Parse(Console.ReadLine());
        string[] arr = new string[N];
        Console.WriteLine("Enter elements of the array:");
        for (int i = 0; i < N; i++)
        {
            arr[i] = Console.ReadLine();
        }
        arr = SortArrayByLengthOfItsElement(arr);
        Console.WriteLine("Sorted array by length og its elements");
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }

    static string[] SortArrayByLengthOfItsElement(string[] arr)
    {
        string bestLength;
        string exChange;
        int position = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            bestLength = arr[i];
            for (int k = i+1; k < arr.Length; k++)
            {
                if (arr[k].Length > bestLength.Length)
                {
                    bestLength = arr[k];
                    position = k;
                }
            }
            if (arr[i].Length != bestLength.Length)
            {
                exChange = arr[i];
                arr[i] = arr[position];
                arr[position] = exChange;
            }            
        }
        return arr;
    }
}

