using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace _01.Melons_and_Watermelons
{
    class MelonsAndWatermelons
    {
        static int CalculateWatermelons(int day)
        {
            switch (day)
            {
                case 1:
                    return 1;
                case 2:
                    return 0;
                case 3:
                    return 1;
                case 4:
                    return 2;
                case 5:
                    return 2;
                case 6:
                    return 1;
                case 7:
                    return 0;
                default:
                    return 0;
            }
        }
        static int CalculateMelons(int day)
        {
            switch (day)
            {
                case 1:
                    return 0;
                case 2:
                    return 2;
                case 3:
                    return 1;
                case 4:
                    return 0;
                case 5:
                    return 2;
                case 6:
                    return 2;
                case 7:
                    return 0;
                default:
                    return 0;
            }
        }
        static void Main(string[] args)
        {
            int dayOfTheWeek = int.Parse(Console.ReadLine());
            int consecutiveDays = int.Parse(Console.ReadLine());
            int melons = 0;
            int watermelons = 0;
            for (int i = 0; i < consecutiveDays; i++)
            {
                melons += CalculateMelons(dayOfTheWeek);
                watermelons += CalculateWatermelons(dayOfTheWeek);
                dayOfTheWeek++;
                if (dayOfTheWeek == 8)
                {
                    dayOfTheWeek = 1;
                }
            }
            if (melons == watermelons)
            {
                Console.WriteLine("Equal amount: {0}",watermelons);
            }
            else if (melons > watermelons)
            {
                Console.WriteLine("{0} more melons",melons-watermelons);
            }else if (watermelons > melons)
            {
                Console.WriteLine("{0} more watermelons",watermelons-melons);
            }
        }
    }
}
