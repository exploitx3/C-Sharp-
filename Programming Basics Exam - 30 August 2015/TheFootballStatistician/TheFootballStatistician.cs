using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace TheFootballStatistician
{
    class TheFootballStatistician
    {
        static int CalcTeam(string input)
        {
            switch (input)
            {
                case "Arsenal":
                    return 0;
                    break;
                case "Chelsea":
                    return 1;
                    break;
                case "Everton":
                    return 2;
                    break;

                case "Liverpool":
                    return 3;
                    break;
                case "ManchesterCity":
                    return 4;
                    break;
                case "ManchesterUnited":
                    return 5;
                    break;

                case "Southampton":
                    return 6;
                    break;
                case "Tottenham":
                    return 7;
                    break;
                default:
                    return 0;
            }
        }
        static void Main(string[] args)
        {

            decimal payment = decimal.Parse(Console.ReadLine());
            int[] teams = new int[8];
            string[] teamNames = new string[8]
            {
                "Arsenal",
                "Chelsea",          
                "Everton",          
                "Liverpool",        
                "Manchester City",  
                "Manchester United", 
                "Southampton",      
                "Tottenham",       
            };
            int counterMatches = 0;
             
            foreach (var elem in teams)
            {
                teams[elem] = 0;
            }
            string[] strInput = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
            while (strInput[0] != "End")
            {
                string firstTeam = strInput[0];
                string outPut = strInput[1];
                string SecondTeam = strInput[2];
                
                if (outPut == "1")
                {
                    teams[CalcTeam(firstTeam)] += 3;
                }
                else if (outPut == "2")
                {
                    teams[CalcTeam(SecondTeam)] += 3;
                }else if (outPut == "X")
                {
                    teams[CalcTeam(firstTeam)] += 1;
                    teams[CalcTeam(SecondTeam)] += 1;
                }
                counterMatches++;
                strInput = strInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
            decimal leva =(payment*counterMatches) * (decimal)1.94;
            Console.WriteLine("{0:F2}lv.",leva);
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("{0} - {1} points.",teamNames[i],teams[i]);
            }
                
            
        }
    }
}
/*
24.33
Chelsea 2 ManchesterCity
Everton 1 ManchesterUnited
Arsenal X Liverpool
Southampton 1 Tottenham
End of the league.
 * 
*/