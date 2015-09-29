using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Bit_Shooter
{
    class BitShooter
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                string[] shootCommand = Console.ReadLine().Split(' ');
                int shotPosition = int.Parse(shootCommand[0]);
                int shotRange = int.Parse(shootCommand[1]);
                
           
                
                number = number & ~((((BigInteger)1 << shotRange) - 1) << shotPosition-shotRange/2);
                
                
            }
            string strNumber = "";
            while (number != 0)
            {
                BigInteger remainder = number%2;
                strNumber = remainder.ToString() + strNumber;
                number /= 2;
            }
            
            char[] chArr = strNumber.ToCharArray();
            
            strNumber = new string(chArr);
            strNumber = strNumber.PadLeft(64, '0');

            int countLeft = 0;
            int countRight = 0;
            for (int i = 0; i < 32; i++)
            {
                if (strNumber[i] == '1')
                {
                    countLeft++;
                }
            }
            for (int i = 32; i < 64; i++)
            {
                if (strNumber[i] == '1')
                {
                    countRight++;
                }
            }

            Console.WriteLine("left: {0}", countLeft);
            Console.WriteLine("right: {0}", countRight);
        }
    }
}
