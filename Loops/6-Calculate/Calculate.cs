using System;


namespace _6_Calculate
{
    class Calculate
    {
        static int fact(int num)
        {
            int result = 1;
            for (int i = 2; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
        static void Main()
        {
            int n;
            int k;
            do
            {
                n = int.Parse(Console.ReadLine());
                k = int.Parse(Console.ReadLine());
                if(1 > k || k >= n || n > 100)
                {
                    Console.WriteLine("(1 < k < n < 100)");
                }
            } while (1 >= k || k >= n || n >= 100);
            Console.WriteLine(fact(n)/fact(k));
        }
    }
}
