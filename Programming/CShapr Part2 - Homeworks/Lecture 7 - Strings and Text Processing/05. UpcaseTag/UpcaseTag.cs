using System;
using System.Text;

class UpcaseTag
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string stringText = Console.ReadLine();
        bool ifNotTag = true;
        bool inTag = false;
        int count = 0;
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < stringText.Length; i++)
        {
            if (stringText[i] == '<')
            {
                ifNotTag = false;
            }
            if (stringText[i] == '>')
            {
                ifNotTag = true;
                count++;
                i++;
            }
            if (count % 2 == 1)
            {
                inTag = true;
            }
            else
            {
                inTag = false;
            }
            if (ifNotTag)
            {
                if (inTag)
                {
                    sb.Append(stringText[i].ToString().ToUpper());
                }
                else
                {
                    sb.Append(stringText[i]);
                }
            }     

        }
        Console.WriteLine("The formated string: {0}", sb.ToString());
    }
}

