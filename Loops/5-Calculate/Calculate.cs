using System;


namespace _5_Calculate
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
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            double sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sum += fact(i) / Math.Pow(x, i);
            }
            Console.WriteLine("{0:F5}",sum);
        }
    }
}
