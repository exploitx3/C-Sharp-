using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Text;

namespace _01_Bunker_Buster
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] sizeStr = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(sizeStr[0]);
            int cols = int.Parse(sizeStr[1]);
            int[,] field = new int[rows,cols];
            for (int i = 0; i < rows; i++)
            {
                string[] inputLine = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < inputLine.Length; j++)
                {
                    field[i, j] = int.Parse(inputLine[i][j].ToString());
                }
            }
            string[] inputStr;
            while ((inputStr = Console.ReadLine().Split(' '))[0] != "cease")
            {
                int bombRow = int.Parse(inputStr[0]);
                int bombCol = int.Parse(inputStr[1]);
                int bombPower = (int)inputStr[2][0];
                field[bombRow, bombCol] -= bombPower;
                for (int i = Math.Max(0,bombRow-1); i <= Math.Min(rows-1,bombRow+1); i++)
                {
                    for (int j = Math.Max(0,bombCol-1); j <= Math.Min(cols-1,bombCol+1); j++)
                    {
                        if (!(i==bombRow && j==bombCol))
                        {
                            double bombHalfPower = Math.Round(bombPower/2.00,MidpointRounding.AwayFromZero);
                            field[i, j] -= (int)Math.Round(bombHalfPower);
                        }
                    }
                }
            }
            int deadCellsCount = 0;
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] <= 0)
                    {
                        deadCellsCount++;
                    }
                }
            }
            double percentDmgDone = ((double)deadCellsCount/(rows*cols));
            Console.WriteLine("Destroyed bunkers: {0}",deadCellsCount);
            Console.WriteLine("Damage done: {0:P1}",percentDmgDone);

        }
    }
}
