using System;

class IfBracketsAreCorrect
{
    static void Main()
    {
        Console.Write("Enter math expression to check for incorrect brackets: ");
        string expression = Console.ReadLine();
        int count = 0;
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                count++;
            }
            if (expression[i] == ')')
            {
                count--;
            }
            if (count < 0)
            {
                break;
            }
        }
        if (count == 0)
        {
            Console.WriteLine("Brackets are correct!");
        }
        else
        {
            Console.WriteLine("Brackets are not correct!");
        }
    }
}

