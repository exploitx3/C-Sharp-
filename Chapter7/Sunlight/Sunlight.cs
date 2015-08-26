using System;

namespace Sunlight
{
    class Sunlight
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int height = n*3;
            int weight = n*3;
            int sunBeam = n*3;
            int diagonalBeam = n*3 - 1;
            int diagonalL = 0;
            int diagonalR = n*3-1;
            
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < weight; j++)
                {
                    if(i >= 0 && j == weight/2)
                    {
                        Console.Write('*');
                    }else if(i > 0 && i<n*3-1 && (j == diagonalL || j == diagonalR))
                    {
                        Console.Write('*');
                    }else if(i >= n && i < n+n && j>=n && j<n+n)
                    {
                        Console.Write('*');
                    }else if(i == height/2)
                    {
                        Console.Write('*');
                    }else
                    {
                        Console.Write('.');
                    }

                }
                Console.WriteLine();
                if(i<n*3-1)
                {
                    diagonalL++;
                    diagonalR--;
                }
            }
        }
    }
}
