using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace _07.Console_Graphics
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = n + 3;
            int width = n*2;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == 1)
                    {
                        Console.Write('*');
                    }else if (i >= height - 2)
                    {
                        Console.Write('~');
                    }
                    else if (i > 1 && ((j >= 0 && j <= n / 2) || (j >= width - n / 2 - 1 && j < width)))
                    {
                        Console.Write('*');
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
