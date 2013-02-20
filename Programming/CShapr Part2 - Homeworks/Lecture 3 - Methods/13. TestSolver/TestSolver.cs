using System;

class TestSolver
{
    static decimal AvarageNumber(int[] arr)
    {
        decimal avarage = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            avarage += arr[i];
        }
        return avarage / arr.Length;
    }

    static decimal LinearEquation(int a, int b)
    {
        return ((-b) / a);
    }

    static bool DecimalValidator(decimal number)
    {
        if (number >= 0)        
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static bool SequanceValidator(int[] arr)
    {
        bool result = false;
        for (int i = 0; i < arr.Length; i++)
        {
            result = (result || (arr[i] != 0));
        }
        return result;
    }

    static bool AValidator(int number)
    {
        if (number == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
        
    static void Main()
    {
        Console.Write("Enter which task to perform: \n1 - Reverse digits of number; \n2 - Calculate the avarage of a sewuance of integers; \n3 - Solve linear equation a*X + b = 0. \nYour choise is:  ");
        int choise = int.Parse(Console.ReadLine());
        switch (choise)
        {
            case 1:
                Console.Write("Enter positive number to reverse:");
                decimal number = decimal.Parse(Console.ReadLine());
                if (DecimalValidator(number))
                {
                    Console.Write("Reversed number is: {0}", ReverseDigits.ReverseDecimal(number));
                }
                else
                {
                    Console.WriteLine("Not valid  number! Please enter positive number next time.");
                }
                Console.WriteLine();
                break;

            case 2:
                Console.Write("Enter how many number will be in the sequance: ");
                int lengthArr = int.Parse(Console.ReadLine());
                int[] arr = new int[lengthArr];
                Console.WriteLine("Enter numbers in the sequance:");
                for (int i = 0; i < lengthArr; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                if (SequanceValidator(arr))
                {
                    Console.WriteLine("The avarege number of the given sequance of numbers is: {0}", AvarageNumber(arr));
                }
                else
                {
                    Console.WriteLine("The sequance is empty!");
                }
                break;

            case 3:
                Console.Write("Enter a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter b: ");
                int b = int.Parse(Console.ReadLine());
                if (AValidator(a))
                {
                    Console.WriteLine("X = {0}", LinearEquation(a, b));
                }
                else
                {
                    Console.WriteLine("Not valid data! -> a=0");
                }
                break;

            default:
                break;
        }
    }
}

