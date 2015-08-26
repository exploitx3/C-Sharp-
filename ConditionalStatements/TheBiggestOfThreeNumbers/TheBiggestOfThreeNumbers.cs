using System;

namespace TheBiggestOfThreeNumbers
{
    class TheBiggestOfThreeNumbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if(a>b && a>c)
            {
                Console.WriteLine(a);
            }else if(b>c && b>a)
            {
                Console.WriteLine(b);
            }else if(c>a && c>b)
            {
                Console.WriteLine(c);
            }
        }
    }
}
