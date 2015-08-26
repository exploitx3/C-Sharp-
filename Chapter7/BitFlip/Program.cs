using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            uint[] intArr = new uint[n];
            for (int i = 0; i < n; i++)
            {
                intArr[i] = uint.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                uint bit = ~intArr[i];
                Console.WriteLine(bit);
            }
            
        }
    }
}
