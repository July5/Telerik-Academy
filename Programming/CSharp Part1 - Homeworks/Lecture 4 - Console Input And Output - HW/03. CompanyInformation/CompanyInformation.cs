using System;

class CompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Enter information about company and its manager:");
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Company phone number: ");
        string companyPhoneNumber = Console.ReadLine();
        Console.Write("Company fax number: ");
        string companyFaxNumber = Console.ReadLine();
        Console.Write("Company web site: ");
        string companyWebSite = Console.ReadLine();
        Console.Write("Manager - first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager - last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager - age: ");
        short managerAge = short.Parse(Console.ReadLine());
        Console.Write("Manager - phone number: ");
        string managerPhoneNumber = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Ingormation about company:");
        Console.WriteLine("Name: " + companyName);
        Console.WriteLine("Address: " + companyAddress);
        Console.WriteLine("Phone number: " + companyPhoneNumber);
        Console.WriteLine("Fax number: "+ companyFaxNumber);
        Console.WriteLine("Web site: " + companyWebSite);
        Console.WriteLine();
        Console.WriteLine("Information about manager:");
        Console.WriteLine("Name: " + managerFirstName +" "+managerLastName);
        Console.WriteLine("Age: " +managerAge);
        Console.WriteLine("Phone number: " + managerPhoneNumber);
    }
}

