using System;

namespace _9_ExtractURLsFromText
{
    class ExtractURLsFromText
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split(' ');
            for (int i = 0; i < text.Length; i++)
            {
                if(text[i].StartsWith("http://") || text[i].StartsWith("www."))
                {
                    Console.WriteLine(text[i]);
                }
            }
        }
    }
}
