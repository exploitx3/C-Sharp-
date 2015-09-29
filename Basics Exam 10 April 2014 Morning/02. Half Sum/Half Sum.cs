using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Half_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int size = n*2;
            int firstSum = 0;
            int secondSum = 0;
            for (int i = 0; i < n; i++)
            {
                int tempNumber = int.Parse(Console.ReadLine());
                firstSum += tempNumber;
            }
            for (int i = n; i < size; i++)
            {
                int tempNumber = int.Parse(Console.ReadLine());
                secondSum += tempNumber;
            }
            if (firstSum == secondSum)
            {
                Console.WriteLine("Yes, sum={0}",firstSum);
            }
            else
            {
                Console.WriteLine("No, diff={0}",Math.Abs(firstSum-secondSum));
            }
        }
    }
}
