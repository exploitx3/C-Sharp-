using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestTriple
{
    class BiggestTriple
    {
        static void Main(string[] args)
        {
            long[] intInput = Console.ReadLine().Split(' ').Select(p => long.Parse(p)).ToArray();
            long sumResult = long.MinValue;
            int maxSumPosition = 0;
            
            
            if (intInput.Length <= 3)
            {
                for (int i = 0; i < intInput.Length; i++)
                {
                    Console.Write(intInput[i] + " ");
                }
            }
            else
            {
                for (int i = 0; i < intInput.Length/3; i++)
                {
                    long currentSum = 0;
                    for (int j = (i*3); j < (i*3)+3; j++)
                    {
                        currentSum += intInput[j];
                    }
                    if (currentSum > sumResult)
                    {
                        sumResult = currentSum;
                        maxSumPosition = i*3;
                    }
                }
                long currentSum2 = 0;
                int counter = intInput.Length;
                while (counter%3 != 0)
                {
                    currentSum2 += intInput[counter-1];
                    counter--;
                }
                if (intInput.Length % 3 != 0)
                {
                    if (currentSum2 > sumResult)
                    {
                        sumResult = currentSum2;
                        maxSumPosition = (intInput.Length/3)*3;
                    }
                }
                if (maxSumPosition < (intInput.Length/3)*3)
                {
                    for (int i = maxSumPosition; i < maxSumPosition + 3; i++)
                    {
                        Console.Write(intInput[i]);
                        if (i != maxSumPosition + 2)
                        {
                            Console.Write(" ");
                        }
                    }
                }
                else
                {
                    for (int i = maxSumPosition; i < intInput.Length; i++)
                    {
                        Console.Write(intInput[i]);
                        if (i != intInput.Length - 1)
                        {
                            Console.Write(" ");
                        }
                    }
                }

            }
           
        }
    }
}
