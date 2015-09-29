using System;


namespace _05.Bit_Sifting
{
    class BitSifting
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());
            int numSeives = int.Parse(Console.ReadLine());
            ulong[] arraySeives = new ulong[numSeives];
            int upBitsCounter = 0;
            for (int i = 0; i < numSeives; i++)
            {
                arraySeives[i] = ulong.Parse(Console.ReadLine());
            }
            ulong numberResult = 0UL;
            
                for (int i = 0; i < 64; i++)
                {
                    ulong currentBit = (number >> i)&1;
                    if (currentBit == 1)
                    {
                        for (int j = 0; j < numSeives; j++)
                        {
                            ulong bitArray = (arraySeives[j] >> i)&1;
                            currentBit ^= bitArray;
                            if (currentBit != 1)
                            {
                                break;
                            }
                        }
                        numberResult |= currentBit << i;
                    }

                }
                
            
            for (int i = 0; i < 64; i++)
            {
                bool isCurrentBitUp = ((numberResult >> i) & 1) == 1;
                if (isCurrentBitUp)
                {
                    upBitsCounter++;
                }
            }
            Console.WriteLine(upBitsCounter);
        }
    }
}
