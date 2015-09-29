using System;

using System.Text;

namespace Wave_Bits
{
    
    class WaveBits
    {
        static string ConvertBinary(ulong var)
        {
            ulong number = var;
            string result = "";
            while (number > 0)
            {
                ulong remainer = number % 2;
                number /= 2;
                result = remainer + result;
            }
            return result;
        }
        static void Main()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            ulong number = ulong.Parse(Console.ReadLine());
            string numberStr = ConvertBinary(number).PadLeft(64,'0');
            int maxSum = 0;
            int maxPosition = 0;
            int currentSum = 1;
            for (int i = 0; i <= 61; i++)
            {
                if (numberStr[i] == '1' && numberStr[i + 1] == '0' && numberStr[i + 2] == '1')
                {
                    currentSum+=2;
                    if (currentSum >= maxSum)
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
            //Console.WriteLine(maxPosition);
            //Console.WriteLine(maxSum);
            int endPosition = maxPosition - maxSum + 1;
            if (maxSum != 0)
            {
                string outPutNumberStr = Convert.ToString(0).PadLeft(64, '0');
                StringBuilder outPutNumber = new StringBuilder(outPutNumberStr);
                for (int i = 0; i < 64; i++)
                {
                    bool shouldBeDeleted = i >= endPosition && i <= maxPosition;
                    if (shouldBeDeleted)
                    {
                        outPutNumber.Remove(63,1);
                        outPutNumber.Insert(0,"0");
                    }
                    else
                    {
                        outPutNumber[i] = numberStr[i];
                    }
                }
                Console.WriteLine(Convert.ToUInt64(Convert.ToString(outPutNumber),2));
            }
            else
            {
                Console.WriteLine("No waves found!");
            }
        }
    }
}