using System;

namespace SpiralMatrix_2
{
    class SpiralMatrix2
    {
       
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] SpiralMatrix = new int[n,n];
            int MaxRevs = n * n;
            int col = 0;
            int row = 0;
            int colUpLimit = n - 1;
            int colDownLimit = 0;
            int rowUpLimit = n - 1;
            int rowDownLimit = 0;
            string direction = "right";
            for (int i = 1; i <= MaxRevs; i++)
            {
                SpiralMatrix[row, col] = i;
                switch(direction)
                {
                    case "right":
                        if(col<colUpLimit)
                        {
                            col++;
                        }
                        else
                        {
                            direction = "down";
                            rowDownLimit++;
                            row++;
                        }
                        break;
                    case "down":
                        if(row<rowUpLimit)
                        {
                            row++;
                        }
                        else
                        {
                            direction = "left";
                            colUpLimit--;
                            col--;
                        }
                        break;
                    case "left":
                        if (col > colDownLimit)
                        {
                            col--;
                        }
                        else
                        {
                            direction = "up";
                            rowUpLimit--;
                            row--;
                        }
                       
                        break;
                    case "up":
                        if(row>rowDownLimit)
                        {
                            row--;
                        }
                        else
                        {
                            direction = "right";
                            colDownLimit++;
                            col++;
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong Direction");
                        break;
                }
            }

           
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("{0,4}",SpiralMatrix[i,j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }

