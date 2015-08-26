using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Power
{
    class TicTacToePower
    {
        static void Main(string[] args)
        {
            int xCordinate = int.Parse(Console.ReadLine());
            int yCordinate = int.Parse(Console.ReadLine());
            int startIndex = int.Parse(Console.ReadLine());
            int indexCounter = 1;
            ulong value = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(i==yCordinate && j==xCordinate)
                    {
                        value = (ulong)Math.Pow(startIndex,indexCounter);
                    }
                    
                    
                    startIndex++;
                    indexCounter++;
                }
                
            }
            Console.WriteLine(value);
        }
    }
}
