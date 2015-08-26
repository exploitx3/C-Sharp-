using System;
using System.Numerics;


namespace _18_TrailingZeros
{
    class TrailingZeros
    {
        static BigInteger fact(BigInteger num)
        {
            BigInteger result = 1;
            for (BigInteger i = 2; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger counter = 0;
            BigInteger fN = fact(n);
            while(fN%10==0)
            {
                counter++;
                fN /= 10;

            }
            Console.WriteLine(counter);
        }
    }
}
