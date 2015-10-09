using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Sum_Of_All_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyString = Console.ReadLine();
            string textString = Console.ReadLine();
            string startKey = Regex.Match(keyString, @"^[A-Za-z_]+?[A-Za-z_](?=\d)").Value;
            string endKey = Regex.Match(keyString, @"(?<=\d)[A-Za-z_]*?$").Value;
            double value = 0d;
            string searchString = String.Format("{0}(.*?){1}", startKey, endKey);
            MatchCollection matchCollection = Regex.Matches(textString,searchString);


            foreach (Match match in matchCollection)
            {
                double number;
                bool isDoubleOrInteger = double.TryParse(match.Groups[1].Value,out number);
                if (isDoubleOrInteger)
                {
                    value += number;
                }

            }

            if ((startKey != "" && endKey != "" )&& value != 0)
            {
                Console.WriteLine("<p>The total value is: <em>{0}</em></p>", value);
            }
            else
            {
                if (startKey == "" || endKey == "")
                {
                    Console.WriteLine("<p>A key is missing</p>");
                }
                else
                {
                    Console.WriteLine("<p>The total value is: <em>nothing</em></p>");
                    
                }
            }
            
        }
    }
}
