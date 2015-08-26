using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiral_Matrix
{
    class SpiralMatrix
    {
        static int Letter(char ch)
        {
            if (ch >= 'A' && ch <= 'Z')
            {
                return 10 * (ch - 64);
            }
            else if (ch >= 'a' && ch <= 'z')
            {
                return 10 * (ch - 96);
            }
            else
            {
                return (int)ch;
            }
        }

        static void Main(string[] args)
        {
            int sizeN = int.Parse(Console.ReadLine());
            int sizeBoard = sizeN * sizeN;
            string strInput = Console.ReadLine();       
            string direction = "right";
            char[,] charArr = new char[sizeN, sizeN];
            int counter = 0;
            int colRightBoarder = sizeN - 1;
            int colLeftBoarder = 0;
            int rowUpBoarder = 0;
            int rowDownBoarder = sizeN - 1;
            int currentRow = -1;
            int currentCol = 0;
            int counterWays = 0;

            while(counterWays < sizeBoard)
            {
                if(direction == "right")
                {
                    currentRow++;
                        while (currentCol <= colRightBoarder)
                        {
                            charArr[currentRow, currentCol] = strInput[counter];
                            counter++;
                            counter %= strInput.Length;
                            counterWays++;
                            currentCol++;
                        }
                        
                        currentRow++;
                        rowUpBoarder++;
                        direction = "down";

                }
                if(direction == "down")
                {
                    currentCol--;
                    while(currentRow<=rowDownBoarder)
                    {
                        charArr[currentRow, currentCol] = strInput[counter];
                        counter++;
                        counter %= strInput.Length;
                        counterWays++;
                        currentRow++;
                    }
                    
                    currentCol--;
                    colRightBoarder--;
                    direction = "left";
                }
                if(direction == "left")
                {
                    currentRow--;
                    while(currentCol>=colLeftBoarder)
                    {
                            charArr[currentRow, currentCol] = strInput[counter];
                            counter++;
                            counter %= strInput.Length;
                            counterWays++;
                            currentCol--;
                     }
                    
                    currentRow--;
                    rowDownBoarder--;
                    direction = "up";

                }
                if(direction == "up")
                {
                    currentCol++;
                    while(currentRow>=rowUpBoarder)
                    {
                        charArr[currentRow, currentCol] = strInput[counter];
                        counter++;
                        counter %= strInput.Length;
                        counterWays++;
                        currentRow--;
                    }
                    
                    currentCol++;
                    colLeftBoarder++;
                    direction = "right";
                    
                }
            }
            int max = int.MinValue;
            int maxRow = 0;
            for (int i = 0; i < sizeN; i++)
            {
                int tempVar = 0;
                for (int j = 0; j < sizeN; j++)
                {
                    tempVar += Letter((charArr[i, j]));

                }
                if(max<tempVar)
                {
                    max = tempVar;
                    maxRow = i;
                }
                
            }
            Console.WriteLine("{0} - {1}",maxRow,max);
            for (int i = 0; i < sizeN; i++)
            {
                for (int j = 0; j < sizeN; j++)
                {
                    Console.Write(charArr[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
