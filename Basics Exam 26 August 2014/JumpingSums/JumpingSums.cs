using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingSums
{
    class JumpingSums
    {
        static void Main(string[] args)
        {
            string[] strInput = Console.ReadLine().Split(' ');
            int numJumps = int.Parse(Console.ReadLine());
            int maxSum = int.MinValue;

           
            for (int i = 0; i < strInput.Length; i++)
            {
                int numCounter = i;
                int counter = 0;
                int sum = int.Parse(strInput[i]);
                while(counter<numJumps)
                {
                    numCounter = numCounter + int.Parse(strInput[numCounter]);
                    if(numCounter>=strInput.Length)
                    {
                        numCounter = numCounter % strInput.Length;
                    }
                    sum += int.Parse(strInput[numCounter]);
                    counter++;

                }
                if(maxSum<sum)
                {
                    maxSum = sum;
                }
                
            }
            Console.WriteLine("max sum = {0}",maxSum);
        }
    }
}
