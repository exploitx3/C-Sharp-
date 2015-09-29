using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace _7.Query_Mess
{
    class QueryMess
    {
        private static void Main()
        {
            string inputStr;
            string pattern = @"([^&=?]*)=([^&=]*)";
            string regex = @"((%20|\+)+)";
            SortedSet<string> set = new SortedSet<string>();
            
            string finalResults = "";
            while ((inputStr = Console.ReadLine()) != "END")
            {
                Regex pairs = new Regex(pattern);
                MatchCollection matches = pairs.Matches(inputStr);
                Dictionary<string, List<string>> results = new Dictionary<string, List<string>>();
                for (int i = 0; i < matches.Count; i++)
                {
                    string field = matches[i].Groups[1].Value;
                    field = Regex.Replace(field, regex, word => " ").Trim();
                    string value = matches[i].Groups[2].Value;
                    value = Regex.Replace(value, regex, word => " ").Trim();
                    if (!results.ContainsKey(field))
                    {
                        List<string> values = new List<string>();
                        values.Add(value);
                        results.Add(field, values);
                    }
                    else
                    {
                        results[field].Add(value);
                    }
                }

                foreach (var pair in results)
                {
                    finalResults += string.Format("{0}=[{1}]", pair.Key, string.Join(", ", pair.Value));
                }
                    finalResults += "\r\n";
            }
            
            Console.Write(finalResults);
            
        }
    }
}
