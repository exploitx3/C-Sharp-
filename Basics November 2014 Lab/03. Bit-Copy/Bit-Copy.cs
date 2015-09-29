using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Bit_Copy
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int result = 0;
            int position = int.Parse(Console.ReadLine());
            for (int i = 0; i < 32; i++)
            {
                
                if (i == 2)
                {
                    result |= ((num >> position) & 1) << 2;
                }
                else
                {
                    result |= num & (1 << i);
                }
            }
            Console.WriteLine(result);
        }
    }
}
