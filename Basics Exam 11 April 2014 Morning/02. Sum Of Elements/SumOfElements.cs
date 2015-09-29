using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sum_Of_Elements
{
     class SumOfElements
    {
        private static void Main(string[] args)
        {
            long[] numArr = Console.ReadLine().Split(' ').ToList().Select(p => long.Parse(p)).ToArray();
            if (numArr.Max()*2 == numArr.Sum())
            {
                Console.WriteLine("Yes, sum={0}", numArr.Max());
            }
            else
            {
                Console.WriteLine("No, diff={0}", Math.Abs(numArr.Sum() - (numArr.Max()*2)));
            }
        }
    }
}
