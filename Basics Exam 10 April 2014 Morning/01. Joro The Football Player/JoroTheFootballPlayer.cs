using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Joro_The_Football_Player
{
    class JoroTheFootballPlayer
    {
        static void Main(string[] args)
        {
            char typeYear = char.Parse(Console.ReadLine());
            int numHolidaysYear = int.Parse(Console.ReadLine());
            int numWeekendsInHometown = int.Parse(Console.ReadLine());
            double normalWeekends = ((52 - numWeekendsInHometown)*2/3.00);
            double totalPlays = normalWeekends + numWeekendsInHometown + (numHolidaysYear/2.00);
            if (typeYear == 't')
            {
                totalPlays += 3;
            }
            Console.WriteLine(Math.Floor(totalPlays));
        }
    }
}
