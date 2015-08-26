using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Longest_Word_in_a_Text
{
    class LongestWordInAText
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split(' ');
            int maxLength = int.MinValue;
            int maxPosition = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if(maxLength < text[i].Length)
                {
                    maxLength = text[i].Length;
                    maxPosition = i;
                }
            }
            
            char[] chText = text[maxPosition].ToCharArray();
            if(chText[chText.Length-1] == '.')
            {
                chText[chText.Length - 1] = ' ';
            }
            for (int i = 0; i < chText.Length; i++)
            {
                Console.Write(chText[i]);
            }
            Console.WriteLine();
        }
    }
}
