using System;
using System.Net;

class DownloadFileFromInternet
{
    static void Main()
    {
        WebClient webClient = new WebClient();
        try
        {
            webClient.DownloadFile("http://bookmans.com/files/images/dog&cat.jpg", @"D:\");
            Console.WriteLine("The file has been downloaded!");
        }
        catch (WebException)
        {
            Console.WriteLine("Invalid web addres or destination foldel, or folder with limited access.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Simultaneous downloads are not supported.");
        }
        finally
        {
            webClient.Dispose();
            Console.WriteLine("Good Bye!");
        }
    }
}

