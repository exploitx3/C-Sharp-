using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintBall
{
    class PaintBall
    {
        static void Main(string[] args)
        {
            int[][] shotArr = new int[25][];
            string[] shotsString = Console.ReadLine().Split(' ');
            char[,] board = new char[10, 10];
            int shotsCount = 0;
            while(shotsString[0] != "End")
            {
                int rows = int.Parse(shotsString[0]);
                int cols = Math.Abs(int.Parse(shotsString[1])-9);
                int radius = int.Parse(shotsString[2]);
                shotArr[shotsCount] = new int[3]{ rows, cols, radius};
                shotsCount++;
                shotsString = Console.ReadLine().Split(' ');
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    board[i, j] = '1';
                }
            }
            for (int i = 0; i < shotsCount; i++)
            {
                int rows = shotArr[i][0];
                int cols = shotArr[i][1];
                int radius = shotArr[i][2];
                int rowCounter = Math.Max(rows - radius, 0);
                int rowLimit = Math.Min(rows + radius+1, 10);
                int colCounter = Math.Max(cols - radius, 0);
                int colLimit = Math.Min(cols + radius+1, 10);
                for (int j = rowCounter; j < rowLimit; j++)
                {
                    for (int k = colCounter; k < colLimit; k++)
                    {
                        if(i%2==0)
                        {
                            board[j, k] = '0';
                        }
                        else
                        {
                            board[j,k] = '1';
                        }
                    }
                }
            }
            int sumBoard = 0;
            for (int i = 0; i < 10; i++)
            {
                string temp = "";
                for (int j = 0; j < 10; j++)
                {
                    temp += board[i,j];
                    
                }
                sumBoard += Convert.ToInt32(temp,2);
                
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(board[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(sumBoard);
        }
    }
}
