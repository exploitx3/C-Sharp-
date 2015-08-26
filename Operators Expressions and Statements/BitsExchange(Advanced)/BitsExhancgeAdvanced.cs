using System;

namespace BitsExchange_Advanced_
{
    class BitsExhancgeAdvanced
    {
        static void Main()
        {
            try
            {
                Console.Write("Num= ");
                uint num = uint.Parse(Console.ReadLine());
                Console.Write("p= ");
                int p = int.Parse(Console.ReadLine());
                Console.Write("q= ");
                int q = int.Parse(Console.ReadLine());
                Console.Write("k= ");
                int k = int.Parse(Console.ReadLine());
                if (q < k)
                {
                    Console.WriteLine("overlapping");
                    return;
                }
                uint bit1 = (uint)((((num & ((((1 << k) - (uint)1)) << p))) >> p) << q);
                uint bit2 = (uint)((((num & ((((1 << k) - (uint)1)) << q))) >> q) << p);
                uint resultMask = (uint)((0 | ((((1 << k) - (uint)1)) << p) | (((1 << k) - (uint)1) << q)));
                uint result = (uint)(((num & ~(resultMask)) | bit1) | bit2);
                string bitStr = Convert.ToString(result, 2);
                string bitNum = Convert.ToString(num, 2);
                Console.WriteLine(result);
                Console.WriteLine(bitNum);
                Console.WriteLine(bitStr);
            }
            catch(System.OverflowException)
            {
                Console.WriteLine("out of range");
            }
        }
    }
}
