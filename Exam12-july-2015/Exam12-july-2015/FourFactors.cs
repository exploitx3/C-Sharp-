using System;


namespace Exam12_july_2015
{
    class FourFactors
    {
        static void Main()
        {
            uint fieldGoals = uint.Parse(Console.ReadLine());
            uint fieldGoalAttempts = uint.Parse(Console.ReadLine());
            uint threePouintField = uint.Parse(Console.ReadLine());
            uint turnOvers= uint.Parse(Console.ReadLine());
            uint OffensiveRebounds = uint.Parse(Console.ReadLine());
            uint OpponentRebounds = uint.Parse(Console.ReadLine());
            uint freeThrows = uint.Parse(Console.ReadLine());
            uint freeThrowAttempts = uint.Parse(Console.ReadLine());
            decimal eFG = Math.Abs((decimal)((fieldGoals + (0.5 * threePouintField)) / fieldGoalAttempts));
            decimal TOV = Math.Abs((decimal)(turnOvers/(fieldGoalAttempts+(0.44*freeThrowAttempts)+turnOvers)));
            decimal ORB = Math.Abs((decimal)((decimal)OffensiveRebounds/(OffensiveRebounds+OpponentRebounds)));
            decimal FT = Math.Abs((decimal)((decimal)freeThrows/fieldGoalAttempts));
            

            Console.WriteLine("eFG% {0:F3}\nTOV% {1:F3}\nORB% {2:F3}\nFT% {3:F3}",eFG,TOV,ORB,FT);
        }
    }
}
