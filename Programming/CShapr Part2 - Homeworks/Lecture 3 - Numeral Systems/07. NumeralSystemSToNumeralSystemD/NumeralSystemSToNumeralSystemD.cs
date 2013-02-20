using System;

public class NumeralSystemSToNumeralSystemD
{
    static void Main()
    {
        Console.Write("Enter number to convert: ");
        string number = Console.ReadLine();
        Console.Write("Enter the index of input numeral system: ");
        int systemS = int.Parse(Console.ReadLine());
        Console.Write("Enter the index of output numeral system: ");
        int systemD = int.Parse(Console.ReadLine());
        Console.WriteLine("The given number {0} in [{1}] numeral system, represented in [{2}] numeral system is: {3}", number, systemS, systemD, AnyNumeralSystemConverter(number, systemS, systemD));
    }

    public static string AnyNumeralSystemConverter(string number, int inputIndex, int outputIndex)
    {
        if (inputIndex < 10)
        {
            
            if (outputIndex < 10)
            {
                return DecimalToBinary.DecToLessThanDec(int.Parse(BinaryToDecimal.LessThanDecToDec(number, inputIndex)), outputIndex);
            }
            else
            {
                return DecimalToHexadecimal.DecToMoreThanDec(int.Parse(BinaryToDecimal.LessThanDecToDec(number, inputIndex)), outputIndex);
            }
        }
        else if (outputIndex < 10)
        {
            return DecimalToBinary.DecToLessThanDec(int.Parse(HexadecimalToDecimal.MoreThanDecToDec(number, inputIndex)), outputIndex);
        }
        else
        {
           return  DecimalToHexadecimal.DecToMoreThanDec(int.Parse(HexadecimalToDecimal.MoreThanDecToDec(number, inputIndex)), outputIndex);
        }
    }
}

