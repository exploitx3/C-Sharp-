using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sequence_of_K_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbersArr = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            long sequenceNumber = Math.Abs(long.Parse(Console.ReadLine()));
            numbersArr.Add(long.MaxValue);
            long currentSum = 1;

            for (int i = 1; i < numbersArr.Count; i++)
            {
                if (numbersArr[i] == numbersArr[i - 1])
                {
                    currentSum++;
                }
                else
                {
                    for (int j = 0; j < currentSum%sequenceNumber; j++)
                    {
                        Console.Write(numbersArr[i - 1] + " ");
                    }
                    currentSum = 1;
                }
            }
        }
    }
}
