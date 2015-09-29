using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace _6.Extract_Hyperlinks
{
    class ExtractHyperlinks
    {
        static void Main()
        {
            string inputStr = Console.ReadLine();
            string multipleString = "";
            while (inputStr != "END")
            {
                multipleString += inputStr;
                inputStr = Console.ReadLine();
            }
            string pattern = @"(?<=<a).*?\s*href\s*=\s*((""[^""]*""(?=>))|('[^']*'(?=>))|([\w\/\:\.]+\.\w{3})|(\/[^'""]*?(?=>)))";
           //string pattern = @"(?s)(?:<a)(?:[\s\n_0-9a-zA-Z=""()]*?.*?)(?:href([\s\n]*)?=(?:['""\s\n]*)?)([a-zA-Z:#\/._\-0-9!?=^+]*(\([""'a-zA-Z\s.()0-9]*\))?)(?:[\s\na-zA-Z=""()0-9]*.*?)?(?:\>)";
            MatchCollection collection = Regex.Matches(multipleString, pattern);
            List<string> resultStrings = new List<string>();
            foreach (Match match in collection)
            {
                StringBuilder tempStr = new StringBuilder(match.Groups[2].Value);
                if (tempStr[0] == '"' || tempStr[0] == '\'')
                {
                    tempStr.Remove(0,1);
                }
                if (tempStr[tempStr.Length-1] == '"' || tempStr[tempStr.Length-1] == '\'')
                {
                    tempStr.Remove(tempStr.Length-1,1);
                }
                resultStrings.Add(tempStr.ToString());
                Console.WriteLine(tempStr);

            }
            //Console.WriteLine(string.Join("\r\n",resultStrings));
        }
    }
}
