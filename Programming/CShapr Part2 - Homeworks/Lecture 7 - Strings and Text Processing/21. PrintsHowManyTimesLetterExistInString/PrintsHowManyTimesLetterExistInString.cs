using System;

class PrintsHowManyTimesLetterExistInString
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string stringText = Console.ReadLine();
        int count = 1;
        for (int i = 0; i < stringText.Length;)
        {
            for (int j = i+1; j < stringText.Length; j++)
            {
                if (stringText[i] == stringText[j])
                {
                    count++;
                    stringText = stringText.Remove(j, 1);
                    j--;
                }
            }
            Console.WriteLine("Symbol \'{0}\' -> found {1} times.", stringText[i], count);
            count = 1;
            stringText = stringText.Remove(i, 1);
            if (stringText.Length == 0)
            {
                break;
            }
        }
    }
}

