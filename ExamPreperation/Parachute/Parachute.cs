using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Parachute
{
    class Parachute
    {
        static void Main(string[] args)
        {
            string inputLine;
            List<string> strList = new List<string>();
            string land = "_~|\\/";
            while ((inputLine = Console.ReadLine()) != "END")
            {
                strList.Add(inputLine);
            }
            int startRow = 0;
            int startCol = 0;
            int endRow = 0;
            int endCol = 0;
            for (int i = 0; i < strList.Count; i++)
            {
                for (int j = 0; j < strList[i].Length; j++)
                {
                    if (strList[i][j] == 'o')
                    {
                        startRow = i+1;
                        startCol = j;
                    }
                }
            }
            int currentCol = startCol;
            for (int i = startRow; i < strList.Count; i++)
            {
                int leftWind = Regex.Matches(strList[i], @"<").Count;
                int rightWind = Regex.Matches(strList[i], @">").Count;
                int valueWind = rightWind - leftWind;
                currentCol = currentCol + valueWind;
                if (land.Contains(strList[i][currentCol]))
                {
                    endRow = i;
                    endCol = currentCol;
                    break;
                }
            }
            switch (strList[endRow][endCol])
            {
                case '_':
                    Console.WriteLine("Landed on the ground like a boss!");
                    Console.Write(endRow + " " + endCol);
                    break;
                case '~':
                    Console.WriteLine("Drowned in the water like a cat!");
                    Console.Write(endRow + " " + endCol);
                    break;
                default:
                    Console.WriteLine("Got smacked on the rock like a dog!");
                    Console.Write(endRow + " " + endCol);
                    break;
            }
            Console.WriteLine();
        }
    }
}
