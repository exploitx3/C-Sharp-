using System;
using System.Numerics;


namespace _7_Calculate
{
    class Calculate
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
        static void Main(string[] args)
        {
            BigInteger n;
            BigInteger k;
            do
            {
                n = BigInteger.Parse(Console.ReadLine());
                k = BigInteger.Parse(Console.ReadLine());
                if (1 > k || k >= n || n > 100)
                {
                    Console.WriteLine("(1 < k < n < 100)");
                }
            } while (1 >= k || k >= n || n >= 100);
            Console.WriteLine(fact(n)/(fact(k)*fact(n-k)));
        }
    }
}
