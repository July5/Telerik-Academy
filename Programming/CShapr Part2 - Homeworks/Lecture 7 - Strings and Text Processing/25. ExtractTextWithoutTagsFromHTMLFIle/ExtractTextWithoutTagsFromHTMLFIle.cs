using System;
using System.Text;

class ExtractTextWithoutTagsFromHTMLFIle
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string stringText = Console.ReadLine();
        bool ifNotTag = true;
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < stringText.Length; i++)
        {
            if (stringText[i] == '>')
            {
                ifNotTag = true;
                if (i != stringText.Length - 1)
                {
                    i++;
                }
            }   
            if (stringText[i] == '<')
            {
                ifNotTag = false;
            }
                     
            if (ifNotTag)
            {                
                sb.Append(stringText[i]);                
            }

        }
        Console.WriteLine("The formated string: {0}", sb.Remove(sb.Length-1, 1).ToString());
    }
}

