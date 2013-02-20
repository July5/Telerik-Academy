using System;

class CountSubstringInString
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string stringText = Console.ReadLine();
        Console.Write("Enter substring: ");
        string SubText = Console.ReadLine();
        int index = 0;
        int count = 0;
        while (true)
        {
            index = stringText.IndexOf(SubText);
            if (index == -1)
            {
                break;
            }
            stringText = stringText.Remove(index, SubText.Length);
            count++;
        }
        Console.WriteLine("Substring exist {0} times in the given string.", count);
    }
}

