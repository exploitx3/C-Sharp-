using System;


namespace _24_BitRoller
{
    class BitRoller
    {
        const int SIZE = 19;
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            int freeze = int.Parse(Console.ReadLine());
            int rolls = int.Parse(Console.ReadLine());
            uint bit;
            uint result = 0;
            int newPos;
            for (int i = 0; i < rolls; i++)
            {
                result = 0;
                for (int pos = 0; pos < SIZE; pos++)
                {
                    bit = (n >> pos) & 1;
                    if(pos == freeze)
                    {
                        result = result | (bit << pos);
                    }
                    else
                    {
                        newPos = pos - 1;
                        if(newPos == freeze)
                        {
                            newPos = newPos - 1;
                            if(newPos < 0)
                            {
                                newPos = SIZE - 1;
                            }
                        }
                        if(newPos < 0)
                        {
                            newPos = SIZE - 1;
                            if(newPos == freeze)
                            {
                                newPos = newPos - 1;
                            }
                        }
                        result = result | (bit << newPos);
                    }


                }
                n = result;
            }
            Console.WriteLine(n);
        }
    }
}