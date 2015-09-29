using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Eclipse
{
    class Eclipse
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = n;
            int width = n*2 + n*2 + n - 1;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if ((i == 0 || i == height-1) && ((j >= 1 && j < n*2 - 1) || (j > width - n*2 && j < width - 1)))
                    {
                        Console.Write('*');
                    }else if (i > 0 && i < height - 1 &&
                              (j == 0 || j == n*2 - 1 || j == n*2 - 1 + n || j == width - 1))
                    {
                        Console.Write('*');
                    }else if (i == n/2 && (j > n*2 - 1 && j < n*2 - 1 + n))
                    {
                        Console.Write('-');
                    }else if (i > 0 && i < height - 1 && ((j > 0 && j < n*2 - 1) || (j > n*2 - 1 + n && j < width - 1)))
                    {
                        Console.Write('/');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
