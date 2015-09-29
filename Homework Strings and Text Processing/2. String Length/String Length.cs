using System;


namespace _2.String_Length
{
    class StringLength
    {
        static void Main(string[] args)
        {
            string strInput = Console.ReadLine();
            while (strInput.Length < 20)
            {
                strInput+='*';
            }
            strInput = strInput.Substring(0,20);
            Console.WriteLine(strInput);
        }
    }
}
