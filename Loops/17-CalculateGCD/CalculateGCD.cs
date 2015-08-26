using System;

namespace _17_CalculateGCD
{
    class CalculateGCD
    {
        static void Main()
        {
            int a = Math.Abs(int.Parse(Console.ReadLine()));
            int b = Math.Abs(int.Parse(Console.ReadLine()));
            int gcd = 0;
            int max = b;
            if(a>b)
            {
                max = a;
            }
            for (int i = 1; i < max; i++)
            {
                if(a % i==0 && b % i==0)
                {
                    gcd = i;
                }
            }
            Console.WriteLine(gcd);
        }
    }
}
