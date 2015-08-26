using System;


namespace DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main()
        {

            int num = int.Parse(Console.ReadLine());
            bool div = (num % 5 == 0) && (num % 7 == 0);
            Console.WriteLine(div);
        }
    }
}
