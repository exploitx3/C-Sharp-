using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Uppercase_Words
{
    class Program
    {
        static void Main()
        {
            string wholeText = "";
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "END")
            {
                wholeText = wholeText + inputLine + "\n";
            }
            MatchCollection matches = Regex.Matches(wholeText, @"[A-Z]+(?=\b|\d)");
            List<string> strMatches = new List<string>();
            foreach (Match match in matches)
            {

                char[] chArrTemp = match.Value.ToCharArray();
                Array.Reverse(chArrTemp);
                
                if (match.ToString() == new string(chArrTemp))
                {
                    string temp = "";
                    foreach (char letter in match.ToString())
                    {
                        temp += letter + "" +letter;
                    }
                    chArrTemp = temp.ToCharArray();
                }
                wholeText = Regex.Replace(wholeText, @"(?<=\b|[0-9])" + match.ToString()+@"(?=\b|[0-9])", new string(chArrTemp));
            }
            Console.WriteLine(System.Security.SecurityElement.Escape(wholeText));
            
        }
    }
}
