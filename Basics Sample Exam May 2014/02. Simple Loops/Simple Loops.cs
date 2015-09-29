using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.Simple_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstElement = BigInteger.Parse(Console.ReadLine());
            BigInteger secondElement = BigInteger.Parse(Console.ReadLine());
            BigInteger thirdElement = BigInteger.Parse(Console.ReadLine());
            int nthElement = int.Parse(Console.ReadLine());
            switch (nthElement)
            {
                case 1:
                    Console.WriteLine(firstElement);
                    return;
                case 2:
                    Console.WriteLine(secondElement);
                    return;
                case 3:
                    Console.WriteLine(thirdElement);
                    return;
                default:
                    break;
            }
            for (BigInteger i = 0; i < nthElement-3; i++)
            {
                BigInteger nextElement = firstElement + secondElement + thirdElement;
                firstElement = secondElement;
                secondElement = thirdElement;
                thirdElement = nextElement;
            }
            Console.WriteLine(thirdElement);

        }
    }
}
