using System;

namespace Four_DigitNumber
{
    class FourDigitNumber
    {
        static void Main()
        {
            int n;
          
            do
            {
                Console.Write("n= ");
                n = int.Parse(Console.ReadLine());
            }
            while((n <= 0) || (((n/1000) % 10) > 9) || (((n/1000) % 10) == 0));
            int a = (n / 1000) % 10;
            int b = (n / 100) % 10;
            int c = (n / 10) % 10;
            int d = n % 10;
            Console.WriteLine("Sum of digits: " + (a+b+c+d));
            Console.WriteLine("Reversed: " + d + " " + c + " " + b + " " + a + " ");
            Console.WriteLine("Last digit in front: " + d + " " + a + " " + b + " " + c + " ");
            Console.WriteLine("Second and third digits exchanged: " + a + " " + c + " " + b + " " + d + " ");
        }
    }
}
