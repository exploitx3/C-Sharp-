using System;

namespace _1.Reverse_String
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string strInput = Console.ReadLine();
            char[] chArr = strInput.ToCharArray();
            Array.Reverse(chArr);
            Console.WriteLine(new string(chArr));

        }
    }
}
