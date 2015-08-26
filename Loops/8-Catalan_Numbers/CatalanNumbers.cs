using System;
using System.Numerics;


namespace CatalanNumbers
{
    class CatalanNumbers
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

            BigInteger n;
            do
            {
                n = BigInteger.Parse(Console.ReadLine());
                if (n < 0 || n >= 100)
                {
                    Console.WriteLine("(0 < n < 100).");
                }
            } while (n < 0 || n >= 100);
            Console.WriteLine(fact(2 * n) / (fact(n + 1) * fact(n)));
        }
    }
}
