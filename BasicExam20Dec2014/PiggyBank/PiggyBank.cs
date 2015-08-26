using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    class PiggyBank
    {
        static void Main(string[] args)
        {
            int priceTank = int.Parse(Console.ReadLine());
            int partyDays = int.Parse(Console.ReadLine());
            double allMonths = Math.Ceiling((double)priceTank / (((30 - partyDays) * 2) - (5 * partyDays)));
            int years = (int)(allMonths / 12);
            int months = (int)(allMonths % 12);
            if((((30-partyDays) * 2) - (5*partyDays) < 0))
            {
                Console.WriteLine("never");
            }
            else
            {
                Console.WriteLine("{0} years, {1} months",years,months);
            }
        }
    }
}
