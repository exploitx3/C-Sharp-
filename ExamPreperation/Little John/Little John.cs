using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Little_John
{
    class Program
    {
        static void Main(string[] args)
        {
            int smallArrows = 0;
            int mediumArrows = 0;
            int largeArrows = 0;
            string fullText = "";
            for (int i = 0; i < 4; i++)
            {
                string input = Console.ReadLine();
                fullText += input + "\n";
            }
            MatchCollection collection = Regex.Matches(fullText, @"(>----->)|(>>----->)|(>>>----->>)");
            
            foreach (Match match in collection)
            {
                if (match.Groups[1].Success)
                {
                    smallArrows++;
                }
                if (match.Groups[2].Success)
                {
                    mediumArrows++;
                }

                if (match.Groups[3].Success)
                {
                    largeArrows++;
                }
            }
            
            
            string number = Convert.ToString(int.Parse(smallArrows + "" + mediumArrows + "" + largeArrows),2);
            char[] tempCharArr = number.ToCharArray();
            Array.Reverse(tempCharArr);
            string reversedNumber = new string(tempCharArr);
            long finalResult = Convert.ToInt64((number + reversedNumber),2);
            Console.WriteLine(finalResult);
            //Console.WriteLine(smallArrows);
            //Console.WriteLine(mediumArrows);
            //Console.WriteLine(largeArrows);
        }
    }
}
