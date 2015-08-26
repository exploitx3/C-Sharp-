using System;


namespace ZeroSubset
{
    class ZeroSubset
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            bool isZeroFound = false;
            if (a == 0)
            {
                Console.WriteLine(a + " = 0");
                isZeroFound = true;
            }
            if (b == 0)
            {
                Console.WriteLine(b + " = 0");
                isZeroFound = true;
            }
            if (c == 0)
            {
                Console.WriteLine(c + " = 0");
                isZeroFound = true;
            }
            if (d == 0)
            {
                Console.WriteLine(d + " = 0");
                isZeroFound = true;
            }
            if (e == 0)
            {
                Console.WriteLine(e + " = 0");
                isZeroFound = true;
            }
            if (a + b == 0)
            {
                Console.WriteLine(a + " + " + b + " = 0");
                isZeroFound = true;
            }
            if (a + c == 0)
            {
                Console.WriteLine(a + " + " + c + " = 0");
                isZeroFound = true;
            }
            if (a + d == 0)
            {
                Console.WriteLine(a + " + " + d + " = 0");
                isZeroFound = true;
            }
            if (a + e == 0)
            {
                Console.WriteLine(a + " + " + e + " = 0");
                isZeroFound = true;
            }
            if (b + c == 0)
            {
                Console.WriteLine(b + " + " + c + " = 0");
                isZeroFound = true;
            }
            if (b + d == 0)
            {
                Console.WriteLine(b + " + " + d + " = 0");
                isZeroFound = true;

            }
            if (b + e == 0)
            {
                Console.WriteLine(b + " + " + e + " = 0");
                isZeroFound = true;
            }
            if (c + d == 0)
            {
                Console.WriteLine(c + " + " + d + " = 0");
                isZeroFound = true;
            }
            if (c + e == 0)
            {
                Console.WriteLine(c + " + " + e + " = 0");
                isZeroFound = true;
            }
            if (d + e == 0)
            {
                Console.WriteLine(d + " + " + e + " = 0");
                isZeroFound = true;
            }
            if (a + b + c == 0)
            {
                Console.WriteLine(a + " + " + b + " + " + c + " = 0");
                isZeroFound = true;
            }
            if (a + b + d == 0)
            {
                Console.WriteLine(a + " + " + b + " + " + d + " = 0");
                isZeroFound = true;
            }
            if (a + b + e == 0)
            {
                Console.WriteLine(a + " + " + b + " + " + e + " = 0");
                isZeroFound = true;
            }
            if (a + c + d == 0)
            {
                Console.WriteLine(a + " + " + c + " + " + d + " = 0");
                isZeroFound = true;
            }
            if (a + c + e == 0)
            {
                Console.WriteLine(a + " + " + c + " + " + e + " = 0");
                isZeroFound = true;
            }
            if (a + d + e == 0)
            {
                Console.WriteLine(a + " + " + d + " + " + e + " = 0");
                isZeroFound = true;
            }
            if (b + c + d == 0)
            {
                Console.WriteLine(b + " + " + c + " + " + d + " = 0");
                isZeroFound = true;
            }
            if (b + c + e == 0)
            {
                Console.WriteLine(b + " + " + c + " + " + e + " = 0");
                isZeroFound = true;
            }
            if (b + d + e == 0)
            {
                Console.WriteLine(b + " + " + d + " + " + e + " = 0");
                isZeroFound = true;
            }
            if (c + d + e == 0)
            {
                Console.WriteLine(c + " + " + d + " + " + e + " = 0");
                isZeroFound = true;
            }
            if (a + b + c + d == 0)
            {
                Console.WriteLine(a + " + " + b + " + " + c + " + " + d + " = 0");
                isZeroFound = true;
            }
            if (a + b + c + e == 0)
            {
                Console.WriteLine(a + " + " + b + " + " + c + " + " + e + " = 0");
                isZeroFound = true;
            }
            if (a + b + d + e == 0)
            {
                Console.WriteLine(a + " + " + b + " + " + d + " + " + e + " = 0");
                isZeroFound = true;
            }
            if (a + c + d + e == 0)
            {
                Console.WriteLine(a + " + " + c + " + " + d + " + " + e + " = 0");
                isZeroFound = true;
            }
            if (b + c + d + e == 0)
            {
                Console.WriteLine(b + " + " + c + " + " + d + " + " + e + " = 0");
                isZeroFound = true;
            }
            if (a + b + c + d + e == 0)
            {
                Console.WriteLine(a + " + " + b + " + " + c + " + " + d + " + " + e + " = 0");
                isZeroFound = true;
            }
            if (isZeroFound == false)
            {
                Console.WriteLine("no zero subset");
            }

        }

    }
}

