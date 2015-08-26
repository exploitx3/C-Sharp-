using System;


namespace BitsExchange
{
    class BitsExchange
    {
        static void Main()
        {
            Console.Write("Num= ");
            uint num = uint.Parse(Console.ReadLine());
            uint bit1 = (num & (7 << 3)) << 21;
            uint bit2 = (num & (7 << 24)) >> 21;
            uint resultMask = (0 | (7 << 3)) | (7 << 24);
            uint result = ((num & ~(resultMask)) | bit1 ) | bit2;
            string resultStr =  Convert.ToString(result,2);
            Console.WriteLine(result);
            Console.WriteLine(resultStr);
        }
    }
}
