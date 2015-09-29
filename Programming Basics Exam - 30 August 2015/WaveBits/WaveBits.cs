using System;

namespace WaveBits
{
    class WaveBits
    {
        static void Main(string[] args)
        {
            int maxSum = 0;
            int currentSum = 1;
            int maxPosition = 0;
            ulong number = ulong.Parse(Console.ReadLine());
            for (int i = 0; i < 62; i++)
            {
                bool isFirstBitUp = ((number >> i) & 1) == 1;
                bool isSecondBitDown =((number >> i+1) & 1) == 0;
                bool isThirdBitUp = ((number >> i+2) & 1) == 1;
                bool isWave = isFirstBitUp && isSecondBitDown && isThirdBitUp;
                if (isWave)
                {
                    currentSum+=2;
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxPosition = i + 2;
                    }
                        i++;
                }
                else
                {
                    currentSum = 1;
                }
            }
            int endIndex = maxPosition - maxSum +1;
            //Console.WriteLine(maxSum);
            //Console.WriteLine(maxPosition);
            //Console.WriteLine(endIndex);
            if (maxSum != 0)
            {
                ulong outputNumber = 0UL;
                for (int i = 63; i >= 0; i--)
                {
                    bool shouldBeDeleted = i >= endIndex && i <= maxPosition;
                    if (shouldBeDeleted)
                    {
                        outputNumber >>= 1;
                    }
                    else
                    {
                        ulong currentBit = (number) & (1UL << i);
                        outputNumber |= currentBit;
                    }
                }
                Console.WriteLine(outputNumber);
            }
            else
            {
                Console.WriteLine("No waves found!");
            }
            
        }
    }
}
