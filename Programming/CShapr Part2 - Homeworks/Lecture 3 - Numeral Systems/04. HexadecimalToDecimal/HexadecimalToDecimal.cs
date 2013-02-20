using System;

public class HexadecimalToDecimal
{
    public static void Main()
    {
        Console.Write("Enter Hexadecimal number: ");
        string number = Console.ReadLine();
        Console.WriteLine("Number in Decimal representation: {0}", MoreThanDecToDec(number, 16));
    }
  
    public static string MoreThanDecToDec(string number, int power)
    {
        char[] charStrng = number.ToCharArray();
        Array.Reverse(charStrng);
        number = new string(charStrng);
        int decimalNumber = 0;
        for (int i = 0; i < number.Length; i++)
        {
            switch (number[i])
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    decimalNumber += (number[i] - '0') * (int)Math.Pow(power, i);
                    break;
                case 'a':
                case 'A':
                    decimalNumber += 10 * (int)Math.Pow(power, i);
                    break;
                case 'b':
                case 'B':
                    decimalNumber += 11 * (int)Math.Pow(power, i);
                    break;
                case 'c':
                case 'C':
                    decimalNumber += 12 * (int)Math.Pow(power, i);
                    break;
                case 'd':
                case 'D':
                    decimalNumber += 13 * (int)Math.Pow(power, i);
                    break;
                case 'e':
                case 'E':
                    decimalNumber += 14 * (int)Math.Pow(power, i);
                    break;
                case 'f':
                case 'F':
                    decimalNumber += 15 * (int)Math.Pow(power, i);
                    break;                  
                default:
                    break;
            }
        }
        return decimalNumber.ToString();
    }
}

