using System;
using System.Collections.Generic;

namespace _6.Palindromes
{
    class Palindromes
    {
        static void Main()
        {
            SortedSet<string> srtSet = new SortedSet<string>();
            string[] inputTxt = Console.ReadLine().Split(new []{' ',',','.','?','!'},StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < inputTxt.GetLength(0); i++)
            {
                char[] chArrReversed = inputTxt[i].ToCharArray();
                Array.Reverse(chArrReversed);
                string strReversed = new string(chArrReversed);
                if (inputTxt[i] == strReversed)
                {
                    srtSet.Add(inputTxt[i]);
                }
            }
            Console.WriteLine(string.Join(", ", srtSet));
        }
    }
}
