using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dream_Item
{
    class DreamItem
    {//"Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug", "Sept", "Oct", "Nov" or "Dec".
        static int Month(string currentMonth)
        {
            switch(currentMonth)
            {
                case "Jan":
                    return 21;
                case "Feb":
                    return 18;
                case "March":
                    return 21;
                case "Apr":
                    return 20;
                case "May":
                    return 21;
                case "June":
                    return 20;
                case  "July":
                    return 21;
                case "Aug":
                    return 21;
                case "Sept":
                    return 20;
                case "Oct":
                    return 21;
                case "Nov":
                    return 20;
                case "Dec":
                    return 21;
                default:
                    return 0;

            }
        }
        static void Main(string[] args)
        {
            string[] strInput = Console.ReadLine().Split('\\');
            int days = Month(strInput[0]);
            double moneyMade = ((double.Parse(strInput[1])) * (int.Parse(strInput[2])) * days);
            if(moneyMade > 700)
            {
                moneyMade += moneyMade * 0.10;
            }
            decimal moneyLeft =  (decimal)(moneyMade - double.Parse(strInput[3]));
            
            if(moneyLeft>=0)
            {
                Console.WriteLine("Money left = {0:F2} leva.", Math.Round(Math.Abs((moneyLeft)), 2));
            }
            else
            {
                Console.WriteLine("Not enough money. {0:F2} leva needed.", Math.Round(Math.Abs((moneyLeft)),4));
            }
        }
    }
}
