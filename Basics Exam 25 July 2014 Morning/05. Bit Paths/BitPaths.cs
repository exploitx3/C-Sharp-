using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Bit_Paths
{
    internal class Program
    {
        static int GetDirection(string direction)
        {
            if (direction.Contains("+"))
            {
                return -Convert.ToInt32(direction[1]-'0');
            }
            else if(direction.Contains("-"))
            {
                return Convert.ToInt32(direction[1]-'0');
            }
            else
            {
                return Convert.ToInt32(direction[0]-'0');
            }
        }
        private static void Main(string[] args)
        {
            byte numDirections = byte.Parse(Console.ReadLine());
            int[][] directionArray = new int[numDirections][];
            byte[] board = new byte[8] {0, 0, 0, 0, 0, 0, 0, 0};
            for (int i = 0; i < numDirections; i++)
            {
                string[] strInput = Console.ReadLine().Split(',');
                directionArray[i] = strInput.ToList().Select(p => GetDirection(p)).ToArray();
                int counter = 0;
                byte direction = (byte)Math.Abs(directionArray[i][0] - 7);
                board[counter] ^= (byte)(1 << direction);
                counter++;
                for (int j = 1; j < 8; j++)
                {
                    direction += (byte)directionArray[i][j];
                    board[counter] ^= (byte)(1 << direction);
                    counter++;
                }
            }
            byte sum = 0;
            for (int i = 0; i < board.Length; i++)
            {
                board[i] >>= 4;
                sum += board[i];
            }
            Console.WriteLine(Convert.ToString(sum,2));
            Console.WriteLine((Convert.ToString(sum,16).ToUpper()));
        }
    }
}

