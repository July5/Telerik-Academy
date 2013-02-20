using System;

class PrintSquareRootOfNumber
{
    static void Main()
    {
        try
        {
            Console.Write("Enter positive integer number: ");
            uint number = uint.Parse(Console.ReadLine());
            Console.WriteLine("The square root fo given number is: {0}", Math.Sqrt(number));
        }       
        catch (FormatException)
        {
            Console.Error.WriteLine("Invalid number!");
        }
        catch (OverflowException)
        {
            Console.Error.WriteLine("Invalid number!");
        }
        catch (ArgumentNullException)
        {
            Console.Error.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}

