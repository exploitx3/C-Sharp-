using System;


namespace CheckABitAtGivenPosition
{
    class CheckABitAtGivenPosition
    {
        static void Main()
        {
            Console.Write("n= ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("p= ");
            int p = int.Parse(Console.ReadLine());
            int Bit = (num & (1 << p)) >> p;
            bool Check = Convert.ToBoolean(Bit);

            Console.WriteLine(Check);
        }
    }
}
