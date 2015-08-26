using System;


namespace Chapter7
{
    class TEST
    {
        static void Main()
        {
          int n = int.Parse(Console.ReadLine());
          int[] intArr = new int[n];
            int bestStart = 0;
            int bestLength = 1;
            int currentStart = 0;
            int currentLength = 1;
            for (int i = 0; i < intArr.Length; i++)
			{
                intArr[i] = int.Parse(Console.ReadLine());
                
			}
            for (int i = 0; i < intArr.Length-1; i++)
            {
                
                if(intArr[i] == intArr[i+1])
                {
                    
                    currentLength++;
                }
                else
                {
                    currentLength = 1;
                    currentStart = i+1;
                }
                if (currentLength > bestLength)
                {
                    bestLength = currentLength;
                    bestStart = currentStart;
                }
            }
            for (int i = bestStart; i < bestStart+bestLength; i++)
            {
                Console.WriteLine(intArr[i]);
            }
        }
    }
}
