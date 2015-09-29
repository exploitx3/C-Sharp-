using System;
using System.Text.RegularExpressions;


namespace _3.Extract_Emails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            string strInput = Console.ReadLine();
            string pattern = @"[\w-\.]+@[\w-]{2,}[.\w-]+\b";
            MatchCollection matches = Regex.Matches(strInput, pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
