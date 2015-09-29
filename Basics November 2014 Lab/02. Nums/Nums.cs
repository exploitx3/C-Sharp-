using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Nums
{
    class Nums
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            for (int i = startNum; i <= endNum; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine("{0:F3}",Math.Sqrt(i));
                }
                else
                {
                    Console.WriteLine("{0:F3}", Math.Pow(i, 2));
                }
            }
        }
    }
}
