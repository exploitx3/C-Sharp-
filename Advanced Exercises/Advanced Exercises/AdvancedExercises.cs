using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Exercises
{
    class AdvancedExercises
    {
        static long Fib(int n)
        {
            if (n < 2)
            {
                return 1;
            }
            return Fib(n - 1) + Fib(n - 2);
        }

        static long Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return Factorial(n-1) * n;   
            }
             
        }

        static long FactorialIterative(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Fib(5));
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine(Factorial(11));
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();
            stopwatch.Start();
            Console.WriteLine(FactorialIterative(11));
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}
