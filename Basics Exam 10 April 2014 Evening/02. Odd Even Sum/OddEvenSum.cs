using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Even_Sum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            int numNumbers = int.Parse(Console.ReadLine());
            int size = numNumbers*2;
            int[] numArr = new int[size];
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 0; i < size; i++)
            {
                numArr[i] = int.Parse(Console.ReadLine());
                if (i%2 == 0)
                {
                    evenSum += numArr[i];
                }
                else
                {
                    oddSum += numArr[i];
                }
            }
            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes, sum={0}",oddSum);
            }
            else
            {
                Console.WriteLine("No, diff={0}",Math.Abs(oddSum-evenSum));
            }

        }
    }
}
