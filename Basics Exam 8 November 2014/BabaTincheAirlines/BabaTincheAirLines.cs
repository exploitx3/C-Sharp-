using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabaTincheAirlines
{
    class BabaTincheAirLines
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(' ');
            string[] secondLine = Console.ReadLine().Split(' ');
            string[] thirdLine = Console.ReadLine().Split(' ');
            int numPassangersFirstClass = int.Parse(firstLine[0]);
            int numFrequentPassangersFirstClass = int.Parse(firstLine[1]);
            int numPassangersWhoTakeMealFirstClass = int.Parse(firstLine[2]);
            int numPassangersBusinessClass = int.Parse(secondLine[0]);
            int numFrequentPassangersBusinessClass = int.Parse(secondLine[1]);
            int numPassangersWhoTakeMealBusinessClass = int.Parse(secondLine[2]);
            int numPassangersEconomyClass = int.Parse(thirdLine[0]);
            int numFrequentPassangersEconomyClass = int.Parse(thirdLine[1]);
            int numPassangersWhoTakeMealEconomyClass = int.Parse(thirdLine[2]);
            int firstClassIncome = (7000 * (numPassangersFirstClass - numFrequentPassangersFirstClass)) + (numFrequentPassangersFirstClass * 2100) + (numPassangersWhoTakeMealFirstClass * (int)(7000 / 2)/100);
            int buisnessClassIncome = (3500 * (numPassangersBusinessClass - numFrequentPassangersBusinessClass)) + (numFrequentPassangersBusinessClass * 1050) + (numPassangersWhoTakeMealBusinessClass * (int)(3500 / 2)/100);
            int economyClassIncome = (1000 * (numPassangersEconomyClass - numFrequentPassangersEconomyClass)) + (numFrequentPassangersEconomyClass * 300) + (numPassangersWhoTakeMealEconomyClass * (int)(1000 / 2)/100);
            int firstClassMaxIncome = (7000 * 12) + (12 * (int)(7000 * 0.5)/100);
            int buisnessClassMaxIncome = (3500 * 28) + (28 * (int)(3500 * 0.5)/100);
            int economyClassMaxIncome = (1000 * 50) + (50 * (int)(1000 * 0.5))/100;
            int babaTincheIncome = firstClassIncome + buisnessClassIncome + economyClassIncome;
            int babaTincheMaxIncome = ((firstClassMaxIncome + buisnessClassMaxIncome + economyClassMaxIncome) - (firstClassIncome + buisnessClassIncome + economyClassIncome));
            Console.WriteLine(babaTincheIncome);
            Console.WriteLine(babaTincheMaxIncome);

        }
    }
}
