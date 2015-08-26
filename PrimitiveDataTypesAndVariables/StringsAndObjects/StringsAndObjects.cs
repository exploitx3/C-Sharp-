using System;

namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main()
        {
            string h = "Hello";
            string w = "World";
            object hw = h + " " + w;
            string hwstring = (string)hw;
            Console.WriteLine(hwstring);
        }
    }
}
