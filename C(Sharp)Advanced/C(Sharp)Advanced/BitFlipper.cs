using System;


namespace C_Sharp_Advanced
{
    class BitFlipper
    {
       
        static void Main()
        {
            ulong num = ulong.Parse(Console.ReadLine());
            int startPos = 62;
            bool threebits;
            while(startPos > 0)
            {
                startPos--;
                threebits = ((num >> startPos) & 7) == 7 || ((num >> startPos) & 7) == 0;
                if(threebits)
                {
                    num = num ^ ((ulong)7 << startPos);
                    startPos -= 2;
                }
            }
            Console.WriteLine(num);

        }
    }
}
