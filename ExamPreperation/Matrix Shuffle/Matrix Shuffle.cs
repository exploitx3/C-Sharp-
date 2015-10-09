using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace Matrix_Shuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string inputString = Console.ReadLine();
            string direction = "Right";
            char[,] matrix = new char[size,size];
            int counter = 0;
            int row = 0;
            int col = 0;
            int rowUpLimit = -1;
            int rowDownLimit = size;
            int colLeftLimit = -1;
            int colRightLimit = size;
            while (inputString.Length < size*size)
            {
                inputString += " ";
            }
            while (counter < inputString.Length)
            {
                switch (direction)
                {
                    case "Right":
                         matrix[row, col] = inputString[counter];
                    counter++;
                    col++;
                    if (col == colRightLimit)
                    {
                        direction = "Down";
                        col--;
                        row++;
                        rowUpLimit++;
                    }
                        break;
                    case "Down":
                        matrix[row, col] = inputString[counter];
                    counter++;
                    row++;
                    if (row == rowDownLimit)
                    {
                        direction = "Left";
                        row--;
                        col--;
                        colRightLimit--;
                    }

                        break;
                    case "Left":
                         matrix[row, col] = inputString[counter];
                    counter++;
                    col--;
                    if (col == colLeftLimit)
                    {
                        direction = "Up";
                        col++;
                        row--;
                        rowDownLimit--;
                    }
                        break;

                    case "Up":

                          matrix[row, col] = inputString[counter];
                    counter++;
                    row--;
                    if (row == rowUpLimit)
                    {
                        direction = "Right";
                        row++;
                        col++;
                        colLeftLimit++;
                    }

                        break;
                }
               
            }
            int extractCounter = 0;
            string whiteSquares = "";
            string blackSquares = "";
            
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i%2 == 0)
                    {
                        if (j%2 == 0)
                        {
                            whiteSquares += matrix[i, j];
                        }
                        else
                        {
                            blackSquares += matrix[i, j];
                        }
                    }
                    else
                    {
                        if (j%2 == 0)
                        {
                            blackSquares += matrix[i, j];

                        }
                        else
                        {
                            whiteSquares += matrix[i, j];
                        }
                    }
                }

            }
            string resultString = whiteSquares + blackSquares;
            string finalString = Regex.Replace(whiteSquares, @"[^A-Za-z]", "") +
                                 Regex.Replace(blackSquares, @"[^A-Za-z]", "");
            string finalStringReversed = new string(finalString.ToCharArray().Reverse().ToArray());
            if (finalString.ToLower() == finalStringReversed.ToLower())
            {
                Console.WriteLine("<div style='background-color:#4FE000'>{0}</div>",resultString);
            }
            else
            {
                Console.WriteLine("<div style='background-color:#E0000F'>{0}</div>",resultString);
            }

        }
    }
}
