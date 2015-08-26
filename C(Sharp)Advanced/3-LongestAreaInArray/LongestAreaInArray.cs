using System;

namespace _3_LongestAreaInArray
{
    class LongestAreaInArray
    {
        static void Main()
        {
            int arrLength = int.Parse(Console.ReadLine());
            string[] arrStr = new string[arrLength];
            for (int i = 0; i < arrLength; i++)
            {
                arrStr[i] = Console.ReadLine();
            }
            string sequenceString = arrStr[0];
            string lastString = arrStr[0];
            int currentSequenceLength = 1;
            int longestSeqLength = 1;
            for (int i = 1; i < arrLength; i++)
            {
                if(lastString == arrStr[i])
                {
                    currentSequenceLength++;
                    if(currentSequenceLength>longestSeqLength)
                    {
                        longestSeqLength = currentSequenceLength;
                        sequenceString = arrStr[i];
                    }
                    lastString = arrStr[i];
                }
                else
                {
                    currentSequenceLength = 1;
                    lastString = arrStr[i];
                }
            }
            Console.WriteLine(longestSeqLength);
            for (int i = 0; i < longestSeqLength; i++)
            {
                Console.WriteLine(sequenceString);
            }
        }
    }
}
