using System;


namespace _12_Randomize
{
    class Randomize
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Random rand = new Random();

            

                for (int j = 1;j <= n; j++)
                {
                    Console.Write(rand.Next(1, n + 1) + " ");
                }
                Console.WriteLine();
        }
    }
}
