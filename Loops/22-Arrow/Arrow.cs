using System;


namespace _22_Arrow
{
    class Arrow
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            int width = n * 2 - 1;
            int height = n * 2 - 1;
            int lowCounter = 1;
            int highCounter = width - 2;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if(i == 0 && j >= n/2 && j < width - n/2)
                    {
                        Console.Write('#');
                    } else if(i > 0 && i < n-1 && j == n/2 )
                    {
                        Console.Write('#');
                    }else if(i > 0 && i < n-1 &&  j == width - n/2 - 1)
                    {
                        Console.Write('#');
                    }
                    else if(i == n - 1 && j<=n/2 )
                    {
                        Console.Write('#');
                    }
                    else if(i == n-1 && j>= width - n/2 -1)
                    {
                        Console.Write('#');
                    }
                    else if(i > n-1 &&  j == lowCounter)
                    {
                        Console.Write('#');
                    }else if(i > n-1 &&  j == highCounter)
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                   

                }
                Console.WriteLine();
                if (i > n - 1 && i < height)
                {
                    lowCounter++;
                    highCounter--;
                }
            }
            
        }

    }
}
