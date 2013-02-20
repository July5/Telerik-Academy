using System;

class FirstElementInArrayBiggerThenNeighbors
{
    static int FirstBiggerElement(int[] arr)
    {   
        for (int i = 0; i < arr.Length; i++)
		{
            if (IfElementOfArrayIsBiggerThanNaighbors.IfElementBiggerThanNeigbors(i, arr) == "True")
            {
                return i;
            }
		}
        return -1;
    }
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
        Console.WriteLine("The index of first element bigger than its neighbors in the given array is: {0}",FirstBiggerElement(arr));
    }
}

