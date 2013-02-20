using System;
using System.Text;

public class ReverseDigits
{
    public static string ReverseDecimal(decimal number)
    {
        string stringNumber = number.ToString();
        StringBuilder sb = new StringBuilder();
        for (int i = stringNumber.Length - 1; i >= 0; i--)
            sb.Append(stringNumber[i]);
        return sb.ToString();
    }

    public static string ReverseString(string stringNumber)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = stringNumber.Length - 1; i >= 0; i--)
            sb.Append(stringNumber[i]);
        return sb.ToString();
    }

    static void Main()
    {
        Console.WriteLine("Enter decimal number: ");
        decimal number = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Reversed number: {0}", ReverseDecimal(number));
    }
}

