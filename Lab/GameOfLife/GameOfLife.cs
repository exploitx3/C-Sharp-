using System;


namespace GameOfLife
{
    class GameOfLife
    {
        static void Main()
        {
            int LiveCells = int.Parse(Console.ReadLine());
            int[] board = new int[10];
            int[] boardCopy = new int[10];
            for (int i = 0; i < LiveCells; i++)
            {
                int row = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());
                board[row] |= 1 << col;
                boardCopy[row] |= 1 << col;
            }
            for (int row = 0; row < boardCopy.Length; row++)
            {
                for (int col = 0; col < boardCopy.Length; col++)
                {
                    int currentBit = (boardCopy[row] >> col) & 1;
                    int startRow = Math.Max(0, row - 1);
                    int endRow = Math.Min(boardCopy.Length - 1, row + 1);
                    int startCol = Math.Max(0, col - 1);
                    int endCol = Math.Min(boardCopy.Length - 1, col + 1);
                    int liveNeighbours = 0;
                    for (int i = startRow; i <= endRow; i++)
                    {
                        for (int j = startCol; j <= endCol; j++)
                        {
                            if (i == row && j == col)
                            {
                                continue;
                            }
                            if (((boardCopy[i] >> j) & 1) == 1)
                            {
                                liveNeighbours++;
                            }
                        }
                    }
                    if (currentBit == 0)
                    {
                        if (liveNeighbours == 3)
                        {
                            board[row] = board[row] | (1 << col);
                        }
                    }
                    else if (currentBit == 1)
                    {
                        if (liveNeighbours < 2 || liveNeighbours > 3)
                        {
                            board[row] = board[row] & ~(1 << col);
                        }
                    }
                    
                     
                }                
            }
            foreach(var element in board)
            {
                Console.WriteLine(Convert.ToString(element,2).PadLeft(10,'0'));
            }
        }
    }
}
