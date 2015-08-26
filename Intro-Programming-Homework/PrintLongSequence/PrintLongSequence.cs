using System;

namespace PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main()
        {
            int x = 2;
            while (x != 1002)
            {
                Console.Write(x + ",");
                if (x > 0)
                {
                    x = x * -1 - 1;
                }
                else
                {
                    x = x * -1 + 1;
                }
            }
            Console.WriteLine();
        }
    }
}
