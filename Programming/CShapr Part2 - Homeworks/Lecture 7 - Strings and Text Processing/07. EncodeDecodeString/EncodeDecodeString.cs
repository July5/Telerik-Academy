using System;
using System.Text;

class EncodeDecodeString
{
    static void Main()
    {
        Console.Write("Enter string to emcode/decode: ");
        string secretString = Console.ReadLine();
        Console.Write("Enter key string for encoding/decoding: ");
        string keyString = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < secretString.Length; i++)
        {
                sb.Append((char)(secretString[i] ^ keyString[i % keyString.Length]));            
        }
        Console.WriteLine();
        Console.WriteLine("The emcoded/decoded string is: {0}", sb.ToString());
        Console.WriteLine();
        string aaa = sb.ToString();
        sb.Clear();
        for (int i = 0; i < aaa.Length; i++)
        {
                sb.Append((char)(aaa[i] ^ keyString[i % keyString.Length]));
        }
        Console.WriteLine("The emcoded/decoded back string is: {0}", sb.ToString());
    }

}