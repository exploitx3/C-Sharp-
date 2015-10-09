using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oh__My_Girl_
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string inputLine;
            string fullText = "";
            while ((inputLine = Console.ReadLine()) != "END")
            {
                fullText += inputLine;
            }
            string pattern = "";
            for (int i = 0; i < key.Length; i++)
            {
                if ((i == 0 || i == key.Length-1 )||(char.IsSymbol(key[i])))
                {
                    pattern += "[" + key[i] + "]";
                }
                else
                {
                    if (char.IsLetter(key[i]))
                    {
                        if (char.IsUpper(key[i]))
                        {
                            pattern += "[A-Z]*";
                        }
                        else
                        {
                            pattern += "[a-z]*";
                        }
                    }
                    else
                    {
                        pattern += "[0-9]*";
                    }
                }
            }
            pattern = pattern + @"([A-Za-z,\s]*?" + pattern;
            Console.WriteLine();
        }
    }
}
