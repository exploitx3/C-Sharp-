using System;

namespace FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            int a;
            do
            {
                Console.Write("(a>=0 and a<=500) a= ");
                a = int.Parse(Console.ReadLine());
            }while(a < 0 || a > 500);
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c= ");
            double c = double.Parse(Console.ReadLine());
            int aBinary = int.Parse(Convert.ToString(a, 2));
            Console.WriteLine("|{0,-8:X}|{1:D10}|{2,10:F2}|{3,-10:F3}|",a,aBinary,b,c);
        }
    }
}
