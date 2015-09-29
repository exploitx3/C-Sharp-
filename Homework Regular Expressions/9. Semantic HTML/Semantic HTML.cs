using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace _9.Semantic_HTML
{
    class SemanticHTML
    {
        static void Main()
        {
            List<string> results = new List<string>();
            string[] semanticTags = {"main", "header", "nav", "article", "section", "aside", "footer"};
            string openingTags = @"<div.*?\b((id|class)\s*=\s*""(.*?)"").*?>";
            string closingTags = @"<\/div>\s.*?(\w+)\s*-->";
            string strInput;
            string strMultiple = "";
            while ((strInput = Console.ReadLine()) != "END")
            {
                MatchCollection matches = Regex.Matches(strInput, openingTags);
                foreach (Match match in matches)
                {
                    string attrName = match.Groups[1].Value;
                    string attrValue = match.Groups[3].Value;

                    if (semanticTags.Contains(attrValue))
                    {
                        string replaceTag = Regex.Replace(match.ToString(), "div", word => attrValue);
                        replaceTag = Regex.Replace(replaceTag, attrName, "");
                        replaceTag = Regex.Replace(replaceTag, "\\s*>", ">");
                        replaceTag = Regex.Replace(replaceTag, "\\s{2,}", " ");
                        strInput = Regex.Replace(strInput, match.ToString(), replaceTag);

                    }
                }

                MatchCollection closing = Regex.Matches(strInput, closingTags);
                foreach (Match match in closing)
                {
                    string commentValue = match.Groups[1].Value;
                    if (semanticTags.Contains(commentValue))
                    {
                        strInput = Regex.Replace(strInput, match.ToString(), string.Format("</" + commentValue + ">"));

                    }
                }
                results.Add(strInput);
            }
            for (int i = 0; i < results.Count; i++)
            {
                Console.WriteLine(results[i]);
            }
        }
    }
}
