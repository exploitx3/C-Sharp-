using System;

internal class IterativeFibonacci
{
    private static void Main()
    {
        Console.Write("n = ");
        var n = int.Parse(Console.ReadLine());
        var result = Fib(n);
        Console.WriteLine("fib({0}) = {1}", n, result);
    }

    private static long Fib(int n)
    {
        long fn = 0;
        long fnMinus1 = 1;
        long fnMinus2 = 1;
        for (var i = 2; i < n; i++)
        {
            fn = fnMinus1 + fnMinus2;
            fnMinus2 = fnMinus1;
            fnMinus1 = fn;
        }
        return fn;
    }
}