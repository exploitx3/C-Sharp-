using System;
using System.Text.RegularExpressions;

namespace _1.Series_of_Letters
{
    class SeriesOfLetters
    {
        static void Main()
        {
            string strInput = Console.ReadLine();
            Console.WriteLine(Regex.Replace(strInput, @"(.)\1+", "$1"));
        }
    }
}
