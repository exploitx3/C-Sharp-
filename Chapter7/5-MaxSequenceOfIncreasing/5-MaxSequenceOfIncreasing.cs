using System;


namespace _5_MaxSequenceOfIncreasing
{
    class MaxSequenceOfIncreasing
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int start = 0;
            int len = 1;
            int bestStart = 0;
            int bestLen = 1;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length-1; i++)
            {
                if(arr[i]  < arr[i+1])
                {
                    len++;
                }
                else
                {
                    len = 1;
                    start = i + 1;
                }
                if(len > bestLen)
                {
                    bestLen = len;
                    bestStart = start;
                }

            }
            for (int i = bestStart; i < bestStart+bestLen; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
