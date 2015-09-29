using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfBits
{
    class GameOfBits
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            string strNumber = Convert.ToString(number,2).PadLeft(32, '0');
            
            string command = Console.ReadLine();
            string newString = null;
            while(command != "Game Over!")
            {
                if(command == "Odd")
                {
                    for (int i = 0; i < strNumber.Length; i++)
                    {
                        if(i%2==1)
                        {
                            newString += strNumber[i];
                        }
                    }
                    strNumber = newString;
                    newString = null;
                }
                if(command == "Even")
                {
                    for (int i = 0; i < strNumber.Length; i++)
                    {
                        if(i%2==0)
                        {
                            newString += strNumber[i];
                        }
                    }
                    strNumber = newString;
                    newString = null;
                }
                command = Console.ReadLine();
            }
            int onesCounter = 0;
            for (int i = 0; i < strNumber.Length; i++)
            {
                if(strNumber[i] == '1')
                {
                    onesCounter++;
                }
            }
            uint finalNumber = Convert.ToUInt32(strNumber, 2);

            Console.WriteLine("{0} -> {1}",finalNumber,onesCounter);
        }
    }
}
