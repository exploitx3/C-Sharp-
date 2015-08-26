using System;

namespace ModifyABit
{
    class ModifyABit
    {
        static void Main()
        {
            Console.Write("n= ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("p= ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("v= ");
            int v = int.Parse(Console.ReadLine());
            int Bit = 0;
            if (v > -1 && v < 2)
            {
                if (v == 1)
                {
                    Bit = (num | (1 << p));
                }
                else
                {
                    Bit = (num & ~(1 << p));
                }

            }
            else
            {
                Console.WriteLine("Wrong Data!");

            }
            
            Console.WriteLine(Bit);
        }
    }
}
