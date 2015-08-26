using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBuilder2
{
    class BitBuilder2
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while(command!="quit")
            {
                int position = int.Parse(command);
                command = Console.ReadLine();
                long mask = 0;                
                mask = (1 << position) - 1;            
                long rightBits = number & mask;
                switch(command)
                {
                    case "flip":
                        {
                            number ^= 1 << position;
                            break;
                        }
                    case "insert":
                        {
                            number >>= position;
                            number <<= position+1;
                            number |= (long)1 << position; //Very Important (long) cast;
                            number |= rightBits;                                                        
                            break;
                        }
                    case "remove":
                        {
                            number >>= position+1;
                            number <<= position;
                            number |= rightBits;
                            break;
                        }
                    default:
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(number);
        }
    }
}
