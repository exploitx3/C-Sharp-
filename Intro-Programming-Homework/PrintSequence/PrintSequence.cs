using System;

namespace PrintSequence
{
    class PrintSequence
    {
        static void Main()
        {
            int x = 2;
            while(x!=12)
            {
                Console.Write(x + ",");
                if(x>0)
                {
                    x=x*-1-1;
                }else
                {
                    x=x*-1+1;
                }
            }
            Console.WriteLine();
        }
    }
}
