using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

class PathsInALabyrinth
{
    static char[,] lab = { { ' ', '*', ' ', ' ', ' ', ' ', '*', ' ', ' ', ' ', ' ', '*', '*', ' ', ' ' },
                         { ' ', ' ', '*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                         { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                         { ' ', ' ', ' ', ' ', ' ', ' ', '*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                         { ' ', ' ', ' ', ' ', ' ', '*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' }, 
                         { ' ', ' ', ' ', ' ', ' ', '*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                         { ' ', '*', '*', '*', ' ', '*', ' ', ' ', ' ', ' ', ' ', '*', '*', '*', '*' },
                         { ' ', ' ', ' ', ' ', ' ', '*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                         { ' ', ' ', ' ', ' ', ' ', '*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'e' } };
    //static char[,] lab = { { ' ', ' ', ' ', '*', ' ', ' ', ' ' },
    //                     { '*', '*', ' ', '*', ' ', '*', ' ' },
    //                     { ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
    //                     { ' ', '*', '*', '*', '*', '*', ' ' },
    //                     { ' ', ' ', ' ', ' ', ' ', ' ', 'e' } };

     static char[] path = new char[lab.GetLength(0)*lab.GetLength(1)];
     static int position = 0;

    static void PrintPath(char[] path, int startPos, int endPos)
    {
        Console.Write("Found path to the exit:");
        for (int i = startPos; i <= endPos; i++)
        {
            Console.Write(path[i]);
        }
        Console.WriteLine();
    }
    static void FindPath(int row, int col, char direction)
    {
        if ((row < 0) || (col < 0) || (row >= lab.GetLength(0)) || (col >= lab.GetLength(1)))
        {
            //out of the labyrinth
            return;
        }
        path[position] = direction;
        position++;
        if (lab[row, col] == 'e')
        {
            PrintPath(path, 1, position - 1);
        }
        if (lab[row, col] == ' ')
        {
            lab[row, col] = 's';

            FindPath(row, col - 1, 'L'); // left
            FindPath(row - 1, col, 'U'); // up
            FindPath(row, col + 1, 'R'); // right
            FindPath(row + 1, col, 'D'); // down 

          //  lab[row, col] = ' ';
        }
        position--;
    }
    static void Main()
    {
        FindPath(0,0,'S');
    }
}