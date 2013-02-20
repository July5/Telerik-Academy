using System;
using System.Text;

class SumOfTwoArraysWithDigits
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        string number1 = Console.ReadLine();
        Console.Write("Enter second number: ");
        string number2 = Console.ReadLine();
        Console.WriteLine("The sum of the two numbers is: {0}", ReverseDigits.ReverseString( SumTwoDigitArrays(IntToArray(number1), IntToArray(number2))));
    }
  
    static int[] IntToArray(string number)
    {
        int[] arr = new int[number.Length];
        for (int i = number.Length - 1; i >= 0; i--)
        {
            arr[i] = (number[i] - '0');
        }
        return arr;
    }

    static string SumTwoDigitArrays(int[] arr1, int[] arr2)
    {
        int lessLength, moreLength;
        bool arr1isbiggerl;
        StringBuilder sb = new StringBuilder();
        if (arr1.Length > arr2.Length)
        {
            lessLength = arr2.Length;
            moreLength = arr1.Length;
            arr1isbiggerl = true;
        }
        else
        {
            lessLength = arr1.Length;
            moreLength = arr2.Length;
            arr1isbiggerl = false;
        }
        sb.Append((arr1[0] + arr2[0]) % 10);
        if (lessLength != 0)
        {
            for (int i = 1; i < lessLength; i++)
            {
                sb.Append((arr1[i] + arr2[i]) % 10 + ((arr1[i - 1] + arr2[i - 1]) / 10));
            }
        }
        if(arr1isbiggerl)
        {
            sb.Append(arr1[lessLength] + ((arr1[lessLength - 1] + arr2[lessLength - 1]) / 10));
            for (int i = lessLength + 1; i < moreLength; i++)
            {
                sb.Append(arr1[i]);
            }
        }
        else
	    {
            sb.Append(arr2[lessLength] + ((arr1[lessLength - 1] + arr2[lessLength - 1]) / 10));
            for (int i = lessLength + 1; i < moreLength; i++)
            {
                sb.Append(arr2[i]);
            }   
	    }
        return sb.ToString();
    }
}

