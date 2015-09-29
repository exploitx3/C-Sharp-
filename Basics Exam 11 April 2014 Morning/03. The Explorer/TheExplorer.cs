using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.The_Explorer
{
    class TheExplorer
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = n;
            int width = n;
            int leftCounter = n / 2;
            int rightCounter = n / 2;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j == leftCounter || j == rightCounter)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('-');
                    }
                }
                Console.WriteLine();
                if (i >= 0 && i < n/2)
                {
                    leftCounter--;
                    rightCounter++;
                }
                else
                {
                    leftCounter++;
                    rightCounter--;
                }


            }
        }
    }
}
