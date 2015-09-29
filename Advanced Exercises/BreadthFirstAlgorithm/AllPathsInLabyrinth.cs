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

    static void Main()
    {
        
    }
}