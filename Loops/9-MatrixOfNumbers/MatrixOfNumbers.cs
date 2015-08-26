using System;


namespace _9_MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            int n;
            int count = 0;
            do
            {
                n = int.Parse(Console.ReadLine());
                if(1 > n || n > 20)
                {
                    Console.WriteLine("(1 ≤ n ≤ 20)");
                }
            }while(1 > n || n > 20);
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n+count; j++)
                {
                    Console.Write(j + " ");
                }
                count++;
                Console.WriteLine();
            }
        }
    }
}
