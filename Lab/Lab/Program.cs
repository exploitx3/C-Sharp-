using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Program
    {
        static int Recursive(int x)
        {
            if (x > 1)
            {
                return x * Recursive(x - 1);
            }
            else
            {
                return 1;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Recursive(5));
        }
       
    }
}
