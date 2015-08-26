using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelerBob
{
    class TravelerBob
    {
        static void Main(string[] args)
        {
            string typeYear = Console.ReadLine();
            int numMonthsContacts = int.Parse(Console.ReadLine());
            int numMonthsWithFamily = int.Parse(Console.ReadLine());
            double travelsYear = 0;
            if(typeYear == "leap")
            {
                double months = numMonthsContacts * 12;
                double familyMonths = 4 * numMonthsWithFamily;
                double leftMonths = ((12 - (numMonthsWithFamily + numMonthsContacts)) * 12) * 0.6;
                double procent = (months + familyMonths + leftMonths) * 0.05;
                travelsYear = months + familyMonths + leftMonths + procent;
            }
            else
            {
                double months = numMonthsContacts * 12;
                double familyMonths = 4 * numMonthsWithFamily;
                double leftMonths = ((12 - (numMonthsWithFamily + numMonthsContacts)) * 12) * 0.6;
                
                travelsYear = months + familyMonths + leftMonths;
            }
            Console.WriteLine(Math.Floor(travelsYear));
        }
    }
}
