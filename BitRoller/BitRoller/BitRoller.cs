using System;


namespace BitRoller
{
    class BitRoller
    {
        const int SIZE = 19;
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int freeze = int.Parse(Console.ReadLine());
            int rotates = int.Parse(Console.ReadLine());
            int bit;
            int result = 0;
            int newPos = 0;
            for (int i = 0; i < rotates; i++)
            {

                result = 0;
                for (int pos = 0; pos < SIZE; pos++)
                {
                    bit = (num >> pos) & 1;
                    if (pos == freeze)
                    {
                        result = result | (bit << pos);
                    }
                    else
                    {
                        newPos = pos - 1;
                        if (newPos == freeze)
                        {
                            newPos = newPos - 1;
                            if (newPos < 0)
                            {
                                newPos = SIZE - 1;
                               
                            }
                         
                        }
                        if (newPos < 0)
                        {
                            newPos = SIZE - 1;
                            if (newPos == freeze)
                            {
                                newPos = newPos - 1;
                            }
                        }

                        result = result | (bit << newPos);
                    }
                    
                }
                num = result;
            }
            
    
           


           Console.WriteLine(Convert.ToString(num, 2).PadLeft(SIZE, '0'));
            Console.WriteLine(num);
        }
    }
}
