using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace The_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            MatchCollection collection = Regex.Matches(inputText, @"[\d+]+");
            string result = "";
            for (int i = 0; i < collection.Count; i++)
            {
                
            
                int number = int.Parse(collection[i].Value);
                string numberString = Convert.ToString(number, 16);
                while (numberString.Length < 4)
                {
                    numberString = "0" + numberString;
                }
                numberString = "0x" + numberString.ToUpper() + (i == collection.Count-1?"":"-");
                result += numberString;
            }
            Console.WriteLine(result);
        }
    }
}
