using System;


namespace ConditionalStatements
{
    class ExchangeIfGreater
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            
            if(a>b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
                Console.WriteLine();
                Console.WriteLine(a + "\t" + b);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(a + "\t" + b);
            }
        }
    }
}
