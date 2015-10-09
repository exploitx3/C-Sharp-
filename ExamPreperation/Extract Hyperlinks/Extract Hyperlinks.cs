using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Extract_Hyperlinks
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullText = "";
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                fullText += input;
            }
            fullText = fullText.Replace("\n", "");
            MatchCollection matchColl = Regex.Matches(fullText, @"<a\s+(?:[^>]+\s+)?href\s*=\s*(?:'([^']*)'|""([^""]*)""|([^\s>]+))[^>]*>");
            for (int i = 0; i < matchColl.Count; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    if (matchColl[i].Length > 1)
                    {
                        Console.WriteLine(matchColl[i].Groups[j].Value);
                    }
                }
                
            }
        }
    }
}
