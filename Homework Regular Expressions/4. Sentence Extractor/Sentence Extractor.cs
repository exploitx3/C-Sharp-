using System;
using System.Text.RegularExpressions;


namespace _4.Sentence_Extractor
{
    class SentenceExtractor
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string inputText = Console.ReadLine();
            string[] textArr = Regex.Split(inputText, @"(?<=[\!|\.|\?])\s+");
            for (int i = 0; i < textArr.Length; i++)
            {
                if (Regex.IsMatch(textArr[i], @"\!|\.|\?"))
                {
                    if (Regex.IsMatch(textArr[i], @"\bis\b"))
                    {
                        Console.WriteLine(textArr[i]+"\r\n");
                    }
                }
               
            }
        }
    }
}
