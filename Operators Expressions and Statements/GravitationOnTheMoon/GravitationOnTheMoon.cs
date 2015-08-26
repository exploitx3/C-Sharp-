using System;


namespace GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main()
        {
            Console.Write("Weight: ");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Your weight on the Moon would be: " + (weight*17)/100);
        }
    }
}
