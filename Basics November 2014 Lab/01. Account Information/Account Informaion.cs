using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Account_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            int clientId = int.Parse(Console.ReadLine());
            double totalAccountBalance = double.Parse(Console.ReadLine());
            string active = "no";
            if (totalAccountBalance >= 0)
            {
                active = "yes";
            }
            
            Console.WriteLine("Hello, {0} {1}",firstName,secondName);
            Console.WriteLine("Client id: {0}",clientId);
            Console.WriteLine("Total balance: {0:F2}",totalAccountBalance);
            Console.WriteLine("Active: {0}",active);
            
        }
    }
}
