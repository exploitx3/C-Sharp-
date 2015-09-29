using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Volleyball
{
    class VolleyBall
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int numHolidaysInYear = int.Parse(Console.ReadLine());
            int numWeekendsInHometown = int.Parse(Console.ReadLine());

            double normalWeekends = (48 - numWeekendsInHometown)*(3/4.00);
            double holidays = numHolidaysInYear*(2/3.00);
            double totalPlays = 0d;
            if (yearType == "leap")
            {
                totalPlays = (numWeekendsInHometown+ normalWeekends + holidays)*1.15d;
            }
            else
            {
                totalPlays = numWeekendsInHometown + normalWeekends + holidays;
            }
            Console.WriteLine(Math.Floor(totalPlays));

        }
    }
}
