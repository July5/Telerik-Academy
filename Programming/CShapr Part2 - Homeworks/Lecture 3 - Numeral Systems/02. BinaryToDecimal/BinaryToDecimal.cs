using System;
using System.Text;

public class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string number = Console.ReadLine();
        Console.WriteLine("Number in Decimal representation: {0}", LessThanDecToDec(number, 2));
    }
  
    public static string LessThanDecToDec(string number, int power)
    {  
        int decimalNumber = 0;
        char[] charStrng = number.ToCharArray();
        Array.Reverse(charStrng);
        number = new string(charStrng);
        for (int i = 0; i < number.Length; i++)
        {
            decimalNumber += ((number[i] - '0') % 10) * (int)Math.Pow(power, i);
        }
        return decimalNumber.ToString();
    }
}

