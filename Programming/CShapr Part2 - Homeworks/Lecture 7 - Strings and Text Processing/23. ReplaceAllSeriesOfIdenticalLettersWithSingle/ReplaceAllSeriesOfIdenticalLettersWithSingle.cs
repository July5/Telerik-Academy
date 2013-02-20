using System;

class ReplaceAllSeriesOfIdenticalLettersWithSingle
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string stringText = Console.ReadLine();
        for (int i = 0; i < stringText.Length; i++)
        {
            for (int j = i + 1; j < stringText.Length; j++)
            {
                if (stringText[i] == stringText[j])
                {
                    stringText = stringText.Remove(j, 1);
                    j--;
                }
                else
                {
                    break;
                }
            }
        }
        Console.WriteLine(stringText);
    }
}
