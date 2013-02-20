using System;
using System.Text;

class ReadReverseAndPrintString
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string stringText = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        for (int i = stringText.Length - 1; i >= 0; i--)
        {
            sb.Append(stringText[i]);
        }
        Console.WriteLine("Reversed string: {0}", sb.ToString());
    }
}

