using System;

namespace ConsoleInput_Output
{
    class SumOf3Numbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Sum =" + (a+b+c));
        }
    }
}
