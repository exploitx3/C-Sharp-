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
            long num = long.Parse(Console.ReadLine());
            long result = 0;
            
            for (int i = 0; i < 32; i++)
            {

                if (i == 3)
                {
                    result |= ((num >> 24) & 1) << i;
                }else  if (i == 4)
                {
                    result |= ((num >> 25) & 1) << i;
                }else  if (i == 5)
                {
                    result |= ((num >> 26) & 1) << i;
                }
                else if (i == 24)
                {
                    result |= ((num >> 3) & 1) << i;
                }else if (i == 25)
                {
                    result |= ((num >> 4) & 1) << i;
                }else if (i == 26)
                {
                    result |= ((num >> 5) & 1) << i;
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

   