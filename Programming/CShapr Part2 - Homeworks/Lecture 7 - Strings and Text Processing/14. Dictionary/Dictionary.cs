using System;

class Dictionary
{
    static void Main()
    {
        string[] dictionary = {".NET - platform for applications from Microsoft",
                               "CLR - managed execution environment for .NET",
                               "namespace - hierarchical - organization of classes"};
        string[] word = new string[dictionary.Length];
        string[] translation = new string[dictionary.Length];
        for (int i = 0; i < dictionary.Length; i++)
        {
            int index = dictionary[i].IndexOf('-');
            word[i] = dictionary[i].Remove(index-1);
            translation[i] = dictionary[i].Remove(0, index + 1);
        }
        Console.Write("Enter word: ");
        string stringText = Console.ReadLine();
        for (int i = 0; i < translation.Length; i++)
        {
            if (string.Compare(stringText, word[i], true) == 0)
            {
                Console.WriteLine("The translation is -> {0}", translation[i]);
            }
        }
    }
}

