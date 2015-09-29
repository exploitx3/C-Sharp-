using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace _01.Work_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            int requiredHours = int.Parse(Console.ReadLine());
            int availableDays = int.Parse(Console.ReadLine());
            int productivityPercent = int.Parse(Console.ReadLine());
            double hoursWork = Math.Floor(((availableDays - (availableDays*0.10d))*12.00)*(productivityPercent/100d));

            if (requiredHours > hoursWork)
            {
                Console.WriteLine("No");
                Console.WriteLine(hoursWork-requiredHours);
            }
            else
            {
                Console.WriteLine("Yes");
                Console.WriteLine(hoursWork - requiredHours);
            }
        }
    }
}
