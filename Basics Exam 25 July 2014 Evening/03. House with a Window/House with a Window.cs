using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.House_with_a_Window
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = 2*n+2;
            int width = 2*n - 1;
            int leftCounter = n-1;
            int rightCounter = n-1;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if ((j == leftCounter || j == rightCounter))
                    {
                        Console.Write('*');
                    }else if (i == n && (j > 0 && j < width - 1))
                    {
                        Console.Write('*');
                    }else if (i > n + n/4 && i <= n + n/4 + n/2 && (j > n/2 && j < width - 1 - n/2))
                    {
                        Console.Write('*');
                    }else if (i == height - 1)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
                if (i < n-1)
                {
                    leftCounter--;
                    rightCounter++;
                }
                else
                {
                    leftCounter = 0;
                    rightCounter = width - 1;
                }
            }
        }
    }
}
