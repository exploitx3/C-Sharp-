using System;
using System.Text.RegularExpressions;


namespace _2.Replace_a_tag
{
    class ReplaceATag
    {
        static void Main()
        {
            //"<ul> <li> <a href="http://softuni.bg">SoftUni</a> </li></ul>"
            //"<ul> <li>  <a href='http://softuni.bg'>SoftUni</a> </li></ul>"
            string strInput = Console.ReadLine();
            string patternA = @"<a";
            string patternB = @"(?<=\w)""|'>";
            string patternC = @"<\/a>";
            string result = Regex.Replace(strInput, patternA, "[URL ");
            result = Regex.Replace(result, patternB, "]");
            result = Regex.Replace(result, @"""|'", "");
            Console.WriteLine(Regex.Replace(result, patternC, "[/URL]"));
        }
    }
}
