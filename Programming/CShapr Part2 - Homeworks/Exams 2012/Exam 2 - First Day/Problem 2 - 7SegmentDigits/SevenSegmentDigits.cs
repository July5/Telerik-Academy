using System;
using System.Collections.Generic;
using System.Text;

class SevenSegmentDigits
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        string[] numbers = new string[numberN];
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < numberN; i++)
        {
            numbers[i] = Console.ReadLine();
        }
        List<string> list = new List<string>();
        string[] matrix = { 
                            "1111110",
                            "0110000",
                            "1101101",
                            "1111001",
                            "0110011",
                            "1011011",
                            "1011111",
                            "1110000",
                            "1111111",
                            "1111011"
                        };
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if ((int.Parse(LessThanDecToDec(numbers[i], 2)) | int.Parse(LessThanDecToDec(matrix[j], 2))) == int.Parse(LessThanDecToDec(matrix[j], 2)))
                {
                    sb.Append(j);
                    break;
                }
            }                
        }
        list.Add(sb.ToString());
        sb.Clear();
        
        Console.WriteLine(list.Count);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
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
