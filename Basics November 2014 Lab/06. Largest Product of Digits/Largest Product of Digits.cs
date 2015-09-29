using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _06.Largest_Product_of_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sum = int.MinValue;
            for (int i = 0; i < number.Length-5; i++)
            {
                int currentSum = (number[i] - '0')*(number[i + 1] - '0')*(number[i + 2] - '0')*(number[i + 3] - '0')*
                                 (number[i + 4] - '0')*(number[i + 5] - '0');
                if (currentSum > sum)
                {
                    sum = currentSum;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
