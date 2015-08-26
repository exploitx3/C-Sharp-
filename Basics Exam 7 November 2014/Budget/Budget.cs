using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    class Budget
    {
        static void Main(string[] args)
        {
            int money = int.Parse(Console.ReadLine());
            int numberWeekDaysOut = int.Parse(Console.ReadLine());
            int numberWeekDaysInHomeTown = int.Parse(Console.ReadLine());
            int percent = ((int)(money * 0.03))+10;
            int weekends = ((4 - numberWeekDaysInHomeTown)*2) * 20;
            int weekDays = ((22 - numberWeekDaysOut) * 10) + numberWeekDaysOut * percent;
            int totalSum = weekDays + weekends + 150;
            if(totalSum<money)
            {
                Console.WriteLine("Yes, leftover {0}.",money-totalSum);
            }else if(totalSum>money)
            {
                Console.WriteLine("No, not enough {0}.",totalSum-money);
            }else if(totalSum==money)
            {
                Console.WriteLine("Exact Budget.");
            }



        }
    }
}
