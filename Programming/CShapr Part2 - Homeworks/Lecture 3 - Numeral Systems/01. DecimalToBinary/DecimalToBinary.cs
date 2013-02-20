using System;
using System.Text;

public class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Number in Binaty representation: {0}", DecToLessThanDec(number, 2));
    }
  
    public static string DecToLessThanDec(int number, int power)
    {
        StringBuilder sb = new StringBuilder();
        while (number != 0)
        {
            sb.Append(number % power);
            number /= power;
        }
        char[] charStrng = sb.ToString().ToCharArray();
        Array.Reverse(charStrng);
        string output = new string(charStrng);
        return output;
    }
}

