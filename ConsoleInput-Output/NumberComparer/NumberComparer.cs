using System;


namespace NumberComparer
{
    class NumberComparer
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double result = (a > b) ? a : b;
            Console.WriteLine("The Greater is: " + result);

        }
    }
}
