﻿using System;
using System.Text;

class HexadecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter Hexadecimal number: ");
        string number = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < number.Length; i++)
        {
            switch (number[i])
            {
                case '0':
                    sb.Append("0000");
                    break;

                case '1':
                    sb.Append("0001");
                    break;

                case '2':
                    sb.Append("0010");
                    break;

                case '3':
                    sb.Append("0011");
                    break;

                case '4':
                    sb.Append("0100");
                    break;

                case '5':
                    sb.Append("0101");
                    break;

                case '6':
                    sb.Append("0110");
                    break;

                case '7':
                    sb.Append("0111");
                    break;

                case '8':
                    sb.Append("1000");
                    break;

                case '9':
                    sb.Append("1001");
                    break;

                case 'a':
                case 'A':
                    sb.Append("1010");
                    break;

                case 'b':
                case 'B':
                    sb.Append("1011");
                    break;

                case 'c':
                case 'C':
                    sb.Append("1100");
                    break;

                case 'd':
                case 'D':
                    sb.Append("1101");
                    break;

                case 'e':
                case 'E':
                    sb.Append("1110");
                    break;

                case 'f':
                case 'F':
                    sb.Append("1111");
                    break;                  

                default:
                    break;
            }
        }
        Console.WriteLine("Number in Binaty representation: {0}", sb.ToString());
    }
}
