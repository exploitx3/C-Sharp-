using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightPath
{
    class KnightPath
    {
        static void Main(string[] args)
        {
            string[] strInput = null;
            string[,] commands = new string[26, 2];
            int countCommands = 0;
            do
            {
                strInput = Console.ReadLine().Split(' ');
                if (strInput[0] != "stop")
                {
                    commands[countCommands, 0] = strInput[0];
                    commands[countCommands, 1] = strInput[1];
                    countCommands++;
                }
                
            } while (strInput[0] != "stop");
            int knightRow = 0;
            int knightCol = 0;
            char[,] board = new char[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    board[i, j] = '0';
                }
            }
            board[0, 7] = '1';
            for (int query = 0; query < countCommands; query++)
            {
                int oldKnightCol = knightCol;
                int oldKnightRow = knightRow;
                switch (commands[query, 0])
                {
                    case "left":
                        knightCol += 2;
                        break;
                    case "right":
                        knightCol -= 2;
                        break;
                    case "down":
                        knightRow += 2;
                        break;
                    case "up":
                        knightRow -= 2;
                        break;
                }
                if (knightRow >= 8 || knightRow < 0)
                {
                    knightCol = oldKnightCol;
                    knightRow = oldKnightRow;
                    continue;
                }
                if (knightCol >= 8 || knightCol < 0)
                {
                    knightCol = oldKnightCol;
                    knightRow = oldKnightRow;
                    continue;
                }
                switch (commands[query, 1])
                {
                    case "left":
                        knightCol += 1;
                        break;
                    case "right":
                        knightCol -= 1;
                        break;
                    case "down":
                        knightRow += 1;
                        break;
                    case "up":
                        knightRow -= 1;
                        break;
                }
                if (knightRow >= 8 || knightRow < 0)
                {
                    knightCol = oldKnightCol;
                    knightRow = oldKnightRow;
                    continue;
                }
                if (knightCol >= 8 || knightCol < 0)
                {
                    knightCol = oldKnightCol;
                    knightRow = oldKnightRow;
                    continue;
                }
                for (int row = 0; row < 8; row++)
                {
                    for (int col = 8; col >= 0; col--)
                    {
                        if(row == knightRow && col == knightCol)
                        {
                            if(board[row, 8 - col - 1] == '1')
                            {
                                board[row, 8 - col - 1] = '0';
                            }
                            else if(board[row, 8-col-1] == '0')
                            {
                                board[row, 8 - col - 1] = '1';
                            }
                        }                      
                    }
                }               
            }
            bool empty = true;
            for (int i = 0; i < 8; i++)
            {
                StringBuilder current = new StringBuilder();
                for (int j = 0; j < 8; j++)
                {
                    current.Append(board[i, j]);
                }
                if ((Convert.ToInt32(current.ToString(), 2) != 0))
                {
                    empty = false;
                    Console.WriteLine(Convert.ToInt32(current.ToString(), 2));
                }
            }
            if(empty)
            {
                Console.WriteLine("[Board is empty]");
            }      
        }
    }
}
