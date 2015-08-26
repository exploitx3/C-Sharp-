using System;


namespace Operators_Expressions_and_Statements
{
    class OddOrEvenIntegers
    {
        static void Main()
        {
            Console.Write("n= ");
            int num = int.Parse(Console.ReadLine());
            bool odd = (num % 2 != 0);
            Console.WriteLine(odd);

        }
    }
}
