using System;

namespace _5_LongestSubSequence
{
    class LongestSubSequence
    {
        static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');

            int[] arrInt = new int[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                arrInt[i] = int.Parse(line[i]);
            }
            int currentNum = 0;
            for (int i = 0; i < arrInt.Length; i++)
            {
                if(i==arrInt.Length-1)
                {
                    if(arrInt[i] > currentNum)
                    {
                        Console.Write(arrInt[i] + " ");
                    }
                    else
                    {
                        break;
                    }
                    
                }else if ((arrInt[i] < arrInt[i+1] || arrInt[i] == arrInt[i+1] )&& arrInt[i] > currentNum )
                {
                    Console.Write(arrInt[i] + " ");
                    if(arrInt[i] != arrInt[i+1])
                    {
                        currentNum = arrInt[i];
                    }
                    
                }

                    

                
            }
            
           
        }
    }
}
