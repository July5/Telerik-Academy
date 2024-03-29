﻿using System;

class ConvertNumberToItsEnglishPronunction
{
    static void Main()
    {
        Console.Write("Enter number in the range [0..999]: ");
        short inputNumber = short.Parse(Console.ReadLine());
        int hundreds = inputNumber / 100;
        int tens = (inputNumber % 100) / 10;
        int ones = inputNumber % 10;
        string stringNumber = "";
        if (inputNumber == 0)
        {
            stringNumber = "Zero";
        }
        else
        {
            switch (hundreds)
            {
                case 1:
                    stringNumber += "One Hundred ";
                    break;
                case 2:
                    stringNumber += "Two Hundred ";
                    break;
                case 3:
                    stringNumber += "Three Hundred ";
                    break;
                case 4:
                    stringNumber += "Four Hundred ";
                    break;
                case 5:
                    stringNumber += "Five Hundred ";
                    break;
                case 6:
                    stringNumber += "Six Hundred ";
                    break;
                case 7:
                    stringNumber += "Seven Hundred ";
                    break;
                case 8:
                    stringNumber += "Eight Hundred ";
                    break;
                case 9:
                    stringNumber += "Nine Hundred ";
                    break;
                default:
                    break;
            }
            if (((inputNumber % 100) > 0) && ((inputNumber % 100) < 20))
            {
                if (hundreds != 0)
                {
                    stringNumber += "and ";
                }
                switch (inputNumber % 100)
                {
                    case 1:
                        stringNumber += "One";
                        break;
                    case 2:
                        stringNumber += "Two";
                        break;
                    case 3:
                        stringNumber += "Three";
                        break;
                    case 4:
                        stringNumber += "Four";
                        break;
                    case 5:
                        stringNumber += "Five";
                        break;
                    case 6:
                        stringNumber += "Six";
                        break;
                    case 7:
                        stringNumber += "Seven";
                        break;
                    case 8:
                        stringNumber += "Eight";
                        break;
                    case 9:
                        stringNumber += "Nine";
                        break;
                    case 10:
                        stringNumber += "Ten";
                        break;
                    case 11:
                        stringNumber += "Eleven";
                        break;
                    case 12:
                        stringNumber += "Twelve";
                        break;
                    case 13:
                        stringNumber += "Thirteen";
                        break;
                    case 14:
                        stringNumber += "Fourteen";
                        break;
                    case 15:
                        stringNumber += "Fifteen";
                        break;
                    case 16:
                        stringNumber += "Sixteen";
                        break;
                    case 17:
                        stringNumber += "Seventeen";
                        break;
                    case 18:
                        stringNumber += "Eighteen";
                        break;
                    case 19:
                        stringNumber += "Nineteen";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                if ((tens > 0) && (ones == 20) && (hundreds != 0))
                {
                    stringNumber += "and ";
                }
                switch (tens)
                {
                    case 2:
                        stringNumber += "Twenty ";
                        break;
                    case 3:
                        stringNumber += "Thitry ";
                        break;
                    case 4:
                        stringNumber += "Fourty ";
                        break;
                    case 5:
                        stringNumber += "Fifty ";
                        break;
                    case 6:
                        stringNumber += "Sixty ";
                        break;
                    case 7:
                        stringNumber += "Seventy ";
                        break;
                    case 8:
                        stringNumber += "Eighty ";
                        break;
                    case 9:
                        stringNumber += "Ninety ";
                        break;
                    default:
                        break;
                }
                switch (ones)
                {
                    case 1:
                        stringNumber += "One";
                        break;
                    case 2:
                        stringNumber += "Two";
                        break;
                    case 3:
                        stringNumber += "Three";
                        break;
                    case 4:
                        stringNumber += "Four";
                        break;
                    case 5:
                        stringNumber += "Five";
                        break;
                    case 6:
                        stringNumber += "Six";
                        break;
                    case 7:
                        stringNumber += "Seven";
                        break;
                    case 8:
                        stringNumber += "Eight";
                        break;
                    case 9:
                        stringNumber += "Nine";
                        break;
                    default:
                        break;
                }
            }
        }
        Console.WriteLine(stringNumber);
    }
}

