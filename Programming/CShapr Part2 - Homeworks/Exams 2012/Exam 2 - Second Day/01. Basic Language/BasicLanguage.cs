using System;
using System.Text;

class BasicLanguage
{

    static StringBuilder final = new StringBuilder();
    static void Main()
    {        
        StringBuilder sb = new StringBuilder();
        bool conditionBrackets = false;
        while (true)
        {
            int symbol = Console.Read();
            if (symbol == -1)
            {
                break;
            }
            char nextChar = (char)symbol;
            if (nextChar == '(')
            {
                conditionBrackets = true;
            }
            if (nextChar == ')')
            {
                conditionBrackets = false;
            }
            if (nextChar == ';' && !conditionBrackets)
            {
                string operand = sb.ToString();
                operand = operand.Trim();
                if (CheckOperator(operand))
                {
                    break;
                }
                sb.Clear();
            }
            else
            {
                sb.Append(nextChar);
            }
            Console.WriteLine(final);
        }
    }

    static bool CheckOperator(string operand)
    {
        string[] commands = operand.Split(')');
        for (int i = 0; i < commands.Length; i++)
        {
            long count = 0;
            string cmd = commands[i].TrimStart();
            if (cmd.StartsWith("PRINT"))
            {
                int startIndex = cmd.IndexOf('(') + 1;
                string content = cmd.Substring(startIndex);
                if (content.Length > 0)
                {
                    for (int j = 0; j < count; j++)
                    {
                        final.Append(content);
                    }
                }
            }
            else if (cmd.StartsWith("FOR"))
            {
                int startIndex = cmd.IndexOf('(') + 1;
                int commaIndex = cmd.IndexOf(',');
                if (commaIndex == -1)
                {
                    int forCount = int.Parse(cmd.Substring(startIndex));
                    count = count * forCount; 
                }
                else
                {
                    int forStart = int.Parse(cmd.Substring(startIndex, commaIndex - startIndex));
                    int forEnd = int.Parse(cmd.Substring(commaIndex + 1));
                    count = count * (forEnd - forStart + 1);
                }
            }
            else if (cmd.StartsWith("EXIT"))
            {
                return true;
            }
        }
        return false;
    }
}

