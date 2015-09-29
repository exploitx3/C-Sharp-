using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Draw_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = n;
            int width = n;
            int leftCounter = 0;
            int rightCounter = width - 1;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j >= leftCounter && j <= rightCounter)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
                if (i < n/2)
                {
                    leftCounter++;
                    rightCounter--;
                }
                else
                {
                    leftCounter--;
                    rightCounter++;
                }
            }
        }
    }
}
