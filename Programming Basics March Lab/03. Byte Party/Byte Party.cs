using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _03.Byte_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            byte[] byteArray = new byte[n];
            for (int i = 0; i < byteArray.Length; i++)
            {
                byteArray[i] = byte.Parse(Console.ReadLine());
            }
            string[] commandInput = Console.ReadLine().Split(' ');
            while (commandInput[0] != "party")
            {
                int command = int.Parse(commandInput[0]);
                int position = int.Parse(commandInput[1]);
                for (int i = 0; i < byteArray.Length; i++)
                {
                    switch (command)
                    {
                        case -1:
                            byteArray[i] ^= (byte)(1 << position);
                            break;
                        case 0:
                            byteArray[i] &= (byte)~(1 << position);
                            break;
                        case 1:
                            byteArray[i] |= (byte) (1 << position);
                            break;
                    }
                }
                commandInput = Console.ReadLine().Split(' ');
            }
            for (int i = 0; i < byteArray.Length; i++)
            {
                Console.WriteLine(byteArray[i]);
            }
        }
    }
}
