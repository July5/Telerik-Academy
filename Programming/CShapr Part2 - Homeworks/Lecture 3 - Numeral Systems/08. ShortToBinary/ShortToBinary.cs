using System;
using System.Text;

class ShortToBinary
{
    static void Main()
    {
        Console.Write("Enter short number: ");
        short number = short.Parse(Console.ReadLine());
        string binaryShort = DecimalToBinary.DecToLessThanDec(Math.Abs(number), 2);
        if (number < 0)
        {
            binaryShort = NegativiDecToBin(number, binaryShort);
        }
        Console.WriteLine("Number in Binary represantation: {0}", binaryShort);

    }

    static string NegativiDecToBin(int number, string binaryNumber)
    {
        if ((number % 8) == 0)
        {
            return ConvertBinaryNumber(binaryNumber, 4);
        }
        else if (number % 4 == 0)
        {
            return ConvertBinaryNumber(binaryNumber, 3);
        }
        else if (number % 2 == 0)
        {
            return ConvertBinaryNumber(binaryNumber, 2);
        }
        else
        {
            return ConvertBinaryNumber(binaryNumber, 1);
        }
    }

    static string ConvertBinaryNumber(string number, int index)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(number);
        for (int i = sb.Length -  1 - index; i >= 0; i--)
        {
            if (sb[i] != '-')
            {
                if (sb[i] == '0')
                {
                    sb[i] = '1';
                }
                else
                {
                    sb[i] = '0';
                }
            }
            else
            {
                sb[i] = ' ';
            }
        }
        for (int i = sb.Length; i < 16; i++)
        {
            sb.Insert(0, '1');
        }
        return sb.ToString();
    }

}

