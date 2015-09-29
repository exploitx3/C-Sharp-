using System;

namespace _5.Unicode_Characters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            string inputStr = Console.ReadLine();
            for (int i = 0; i < inputStr.Length; i++)
            {
                Console.Write("\\u" + ((int) inputStr[i]).ToString("x4"));
            }
            Console.WriteLine();
        }
    }
}
