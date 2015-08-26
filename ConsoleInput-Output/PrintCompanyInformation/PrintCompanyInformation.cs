using System;


namespace PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main()
        {
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Company address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Fax number: ");
            string faxNumber = Console.ReadLine();
            Console.Write("Web site: ");
            string webSite = Console.ReadLine();
            Console.Write("Manager first name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Manager last name: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Manager age: ");
            string managerAge = Console.ReadLine();
            Console.Write("Manager phone: ");
            string managerPhone = Console.ReadLine();
            Console.WriteLine("\u000A" + companyName);
            Console.Write("Address: ");
            Console.WriteLine(companyAddress);
            Console.Write("Tel. ");
            Console.WriteLine(phoneNumber);
            Console.Write("Fax: ");
            if(faxNumber == "")
            {
                Console.WriteLine("(no fax)");
            }
            else
            {
                Console.WriteLine(faxNumber);
            }
            Console.Write("Web site: ");
            Console.WriteLine(webSite);
            Console.WriteLine("Manager: " + managerFirstName + " " + managerLastName + " (age:" + managerAge + ", tel. " + managerPhone + ")");

           
        }
    }
}
