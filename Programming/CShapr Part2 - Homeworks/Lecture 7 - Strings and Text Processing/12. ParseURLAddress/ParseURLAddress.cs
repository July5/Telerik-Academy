using System;
using System.Text;

class ParseURLAddress
{
    static void Main()
    {
        Console.Write("Enter URL address: ");
        string addressURL = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        int count = 0;
        for (int i = 0; i < addressURL.Length; i++)
        {
            if ((addressURL[i] == '/') && (count < 2))
            {
                if (count == 0)
                {
                    Console.WriteLine("[protocol] = {0}", sb.ToString().Trim(':'));
                } 
                if (count == 1)
	            {
		            Console.WriteLine("[server] = {0}", sb.ToString());
	            }
                sb.Clear();
                i++;
                count++;
            }
            else
            {
                if (count == 2)
                {
                    i -= 2;
                    count++;
                }
                sb.Append(addressURL[i]);
            }
        }
        Console.WriteLine("[resource] = {0}", sb.ToString());

    }
}

