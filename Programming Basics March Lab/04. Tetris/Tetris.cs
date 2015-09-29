using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Tetris
{
    class Tetris
    {
        static void Main(string[] args)
        {
            string[] inputLength = Console.ReadLine().Split(' ');
            int rows = int.Parse(inputLength[0]);
            int cols = int.Parse(inputLength[1]);
            char[,] board = new char[rows*2,cols*2];
            for (int i = 0; i < rows*2; i++)
            {
                for (int j = 0; j < cols*2; j++)
                {
                    board[i, j] = '-';
                }
            }
            for (int i = 0; i < rows; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < input.Length; j++)
                {
                    board[i, j] = input[j];
                }
            }
            int iCounter = 0;
            int jCounter = 0;
            int lCounter = 0;
            int zCounter = 0;
            int sCounter = 0;
            int tCounter = 0;
            int oCounter = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    bool I = board[i, j] == 'o' && board[i + 1, j] == 'o' && board[i + 2, j] == 'o' &&
                             board[i + 3, j] == 'o';
                    bool L = board[i, j] == 'o' && board[i + 1, j] == 'o' && board[i + 2, j] == 'o' &&
                             board[i + 2, j + 1] == 'o';
                    bool J = board[i, j + 1] == 'o' && board[i + 1, j + 1] == 'o' && board[i + 2, j + 1] == 'o'
                             && board[i + 2, j] == 'o';
                    bool O = board[i, j] == 'o' && board[i, j + 1] == 'o' && board[i + 1, j] == 'o' &&
                             board[i + 1, j + 1] == 'o';
                    bool Z = board[i, j] == 'o' &&  board[i, j + 1] == 'o' && board[i + 1, j + 1] == 'o' &&
                             board[i + 1, j + 2] == 'o';
                    bool S = board[i + 1, j] == 'o' && board[i + 1, j + 1] == 'o' && board[i, j + 1] == 'o' &&
                             board[i, j + 2] == 'o';
                    bool T = board[i, j] == 'o' && board[i, j + 1] == 'o' && board[i + 1, j + 1] == 'o' &&
                             board[i, j + 2] == 'o';
                    if (I)
                    {
                        iCounter++;
                    }
                    if (L)
                    {
                        lCounter++;
                    }
                    if (J)
                    {
                        jCounter++;
                    }
                    if (O)
                    {
                        oCounter++;
                    }
                    if (Z)
                    {
                        zCounter++;
                    }
                    if (S)
                    {
                        sCounter++;
                    }
                    if (T)
                    {
                        tCounter++;
                    }
                }
            }
            Console.WriteLine("I:{0}, L:{1}, J:{2}, O:{3}, Z:{4}, S:{5}, T:{6}"
                ,iCounter,lCounter,jCounter,oCounter,zCounter,sCounter,tCounter);
        }
    }
}
