using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Electricity
{
    class Electricity
    {
        static int CalculateWatts(int hours,int floor,int flat)
        {
            if (hours >= 14 && hours < 19)
            {
                return (int)Math.Floor((floor*flat)*452.86d);
            }
            if (hours >= 19 && hours < 24)
            {
                return (int) Math.Floor((floor*flat)*1459.11d);
            }
            if (hours >= 0 && hours < 9)
            {
                return (int)Math.Floor((floor * flat) * 1107.73d);
            }
            return 0;
        }
        static void Main(string[] args)
        {
            int floorsNumber = int.Parse(Console.ReadLine());
            int flatNumber = int.Parse(Console.ReadLine());
            string[] dateInput = Console.ReadLine().Split(':');
            int hours = int.Parse(dateInput[0]);
            int minutes = int.Parse(dateInput[1]);
            Console.WriteLine("{0} Watts",CalculateWatts(hours,floorsNumber,flatNumber));

        }
    }
}
