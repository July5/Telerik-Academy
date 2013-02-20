using System;
using System.Numerics;
using System.Text;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        BigInteger binaryNumber = 0;
        while (number != 0)
        {
            binaryNumber = number % 10000;
            number /= 10000;
            switch ((int)binaryNumber)
            {
                case 0:
                    sb.Append("0");
                    break;

                case 1:
                    sb.Append("1");
                    break;

                case 10:
                    sb.Append("2");
                    break;

                case 11:
                    sb.Append("3");
                    break;

                case 100:
                    sb.Append("4");
                    break;

                case 101:
                    sb.Append("5");
                    break;

                case 110:
                    sb.Append("6");
                    break;

                case 111:
                    sb.Append("7");
                    break;

                case 1000:
                    sb.Append("8");
                    break;

                case 1001:
                    sb.Append("9");
                    break;

                case 1010:
                    sb.Append("A");
                    break;

                case 1011:
                    sb.Append("B");
                    break;

                case 1100:
                    sb.Append("C");
                    break;

                case 1101:
                    sb.Append("D");
                    break;

                case 1110:
                    sb.Append("E");
                    break;

                case 1111:
                    sb.Append("F");
                    break;

                default:
                    break;
            }
        }
        char[] charStrng = sb.ToString().ToCharArray();
        Array.Reverse(charStrng);
        string output = new string(charStrng);
        Console.WriteLine("Number in Hexadecimal representation: {0}", output);
    }
}

