using System;



namespace ExtractBitN3
{
    class ExtractBitN3
    {
        static void Main()
        {
            Console.Write("n= ");
            uint num = uint.Parse(Console.ReadLine());
            uint Bit = (num & (1 << 3)) >> 3;
            Console.WriteLine(Bit);

        }
    }
}
