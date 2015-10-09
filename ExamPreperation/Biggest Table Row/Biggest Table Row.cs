using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Biggest_Table_Row
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strList = new List<string>();
            List<string> maxNumbers = new List<string>();
            string input;
            while ((input = Console.ReadLine()) != "</table>")
            {
                strList.Add(input);
            }
            double maxRowSum = double.MinValue;

            int maxIndex = 0;
            for (int i = 0; i < strList.Count; i++)
            {
                List<string> tempStrings = new List<string>();
                double currentRowSum = 0;
                MatchCollection collection = Regex.Matches(strList[i], @"(<\/td><td>)(.+?)(?=<)");
                for (int j = 0; j < collection.Count; j++)
                {
                    
                    double value;
                    bool isNubmer = double.TryParse(collection[j].Groups[2].Value,out value);
                    if (isNubmer)
                    {
                        currentRowSum += value;
                        tempStrings.Add(collection[j].Groups[2].Value);
                    }
                }
                if (currentRowSum > maxRowSum && tempStrings.Count != 0)
                {
                    maxRowSum = currentRowSum;
                    maxNumbers = tempStrings;
                }
            }
            
            MatchCollection finalCollection = Regex.Matches(strList[maxIndex], @"(<\/td><td>)(.+?)(?=<)");
            
            for (int i = 0; i < finalCollection.Count; i++)
            {
                double value;
                bool isNubmer = double.TryParse(finalCollection[i].Groups[2].Value, out value);
                if (isNubmer)
                {
                    maxNumbers.Add(finalCollection[i].Groups[2].Value);
                }
            }
            if (maxRowSum != double.MinValue)
            {
                
                Console.Write(maxRowSum + " = ");
                for (int i = 0; i < maxNumbers.Count; i++)
                 {
                    Console.Write(maxNumbers[i] + (i==maxNumbers.Count-1?"":" + "));
                 }
            }
            else
            {
                Console.WriteLine("no data");
            }
            Console.WriteLine();
            


        }
    }
}
