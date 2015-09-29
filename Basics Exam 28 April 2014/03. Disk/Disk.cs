using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Disk
{
    class Disk
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int radius = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((Math.Pow(i - n/2, 2) + Math.Pow(j - n/2, 2)) <= Math.Pow(radius, 2))
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
