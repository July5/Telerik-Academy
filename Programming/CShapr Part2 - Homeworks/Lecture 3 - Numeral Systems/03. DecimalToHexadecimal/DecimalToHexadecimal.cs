using System;
using System.Text;

public class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Number in Hexadecimal representation: {0}", DecToMoreThanDec(number, 16));
    }
  
    public static string DecToMoreThanDec(int number, int power)
    {
        StringBuilder sb = new StringBuilder();
        string digitHolder;
        while (number != 0)
        {
            digitHolder = (number % power).ToString();
            if ((number % power) > 9)
            {
                switch (digitHolder)
                {
                    case "10":
                        sb.Append("A");
                        break;
                    case "11":
                        sb.Append("B");
                        break;
                    case "12":
                        sb.Append("C");
                        break;
                    case "13":
                        sb.Append("D");
                        break;
                    case "14":
                        sb.Append("E");
                        break;
                    case "15":
                        sb.Append("F");                       
                        break;
                    default:
                        break;
                }
            }
            else
            {
                sb.Append(digitHolder);
            }
            number /= 16;
        }
        char[] charStrng = sb.ToString().ToCharArray();
        Array.Reverse(charStrng);
        string output = new string(charStrng);
        return output;
    }
}

