using System;

namespace ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main()
        {
            Console.Write("n= ");
            double n =  double.Parse(Console.ReadLine());
            int num = ((int)(n / 100)) % 10;
            bool is7 = num % 7 == 0;
            Console.WriteLine(is7);
    
        }
    }
}
