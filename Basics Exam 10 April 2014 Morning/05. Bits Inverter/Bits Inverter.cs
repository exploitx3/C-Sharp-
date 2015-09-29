using System;

namespace _05.Bits_Inverter
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int[] numbersArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbersArr[i] = int.Parse(Console.ReadLine());
            }
            
            for (int i = 0,j=0,counter=0; i < n*8; i++,j++)
            {
                j %= 8;
                if (i%step == 0)
                {
                    numbersArr[counter] ^= (128 >> j);
                }
                if (j == 7)
                {
                    counter++;
                }
            }
            foreach (int i in numbersArr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
