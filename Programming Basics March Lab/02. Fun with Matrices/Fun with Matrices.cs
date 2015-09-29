using System;
using System.Linq;


namespace _02.Fun_with_Matrices
{
    class Program
    {
        static void Main()
        {
            double startNumber = double.Parse(Console.ReadLine());
            double step = double.Parse(Console.ReadLine());
            double[,] numArray = new double[4,4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    numArray[i, j] = startNumber;
                    startNumber += step;
                    //Console.Write(numArray[i,j]+" ");
                }
                //Console.WriteLine();
            }
            string[] commandInput = Console.ReadLine().Split(' ');
            while(commandInput[0] != "Game" && commandInput[1] != "Over!")
            {
                int row;
                int col;
                double num = 0d;
                switch (commandInput[2])
                {
                    case "multiply":
                        row = int.Parse(commandInput[0]);
                        col = int.Parse(commandInput[1]);
                        num = double.Parse(commandInput[3]);
                        numArray[row,col] *= num;
                        break;
                    case "sum":
                         row = int.Parse(commandInput[0]);
                         col = int.Parse(commandInput[1]);
                         num = double.Parse(commandInput[3]);
                        numArray[row,col] += num;
                        break;
                    case "power":
                        row = int.Parse(commandInput[0]);
                        col = int.Parse(commandInput[1]);
                        num = double.Parse(commandInput[3]);
                        numArray[row,col] = Math.Pow(numArray[row,col],num);
                        break;
                }
                commandInput = Console.ReadLine().Split(' ');
            }
           double sumRow =  double.MinValue;
           double rowPosition = 0;
           double sumCols = double.MinValue;
           double columnPosition = 0;
           double sumLeftDiagonal = 0;
           double sumRightDiagonal = 0;
            for (int i = 0; i < 4; i++)
            {
                double currentRowSum = 0;
                double currentColSum = 0;
                for (int j = 0; j < 4; j++)
                {
                    currentRowSum += numArray[i, j];
                    currentColSum += numArray[j, i];
                    if (i == j)
                    {
                        sumLeftDiagonal += numArray[i, j];
                    }
                    if (i == 3 - j)
                    {
                        sumRightDiagonal += numArray[i, j];
                    }
                }
                if (currentRowSum > sumRow)
                {
                    sumRow = currentRowSum;
                    rowPosition = i;
                }
                if (currentColSum > sumCols)
                {
                    sumCols = currentColSum;
                    columnPosition = i;
                }
            }

            double[] maxValues = new double[4];
            maxValues[0] = sumRow;
            maxValues[1] = sumCols;
            maxValues[2] = sumLeftDiagonal;
            maxValues[3] = sumRightDiagonal;
            //Console.WriteLine(sumLeftDiagonal);
            //Console.WriteLine(sumRightDiagonal);
            //double max = double.MinValue;
            for (int i = 0; i < 4; i++)
            {
                if (maxValues[i] == double.MinValue)
                {
                    maxValues[i] = 0;
                }
            }
            if (maxValues.Max() == maxValues[0])
            {
                Console.WriteLine("ROW[{0}] = {1:F2}",rowPosition,Math.Round(sumRow,2));
            }else if (maxValues.Max() == maxValues[1])
            {
                Console.WriteLine("COLUMN[{0}] = {1:F2}", columnPosition, Math.Round(sumCols,2));
            }
            else if (maxValues.Max() == maxValues[2])
            {
                Console.WriteLine("LEFT-DIAGONAL = {0:F2}", Math.Round(sumLeftDiagonal,2));
            }
            else if (maxValues.Max() == maxValues[3])
            {
                Console.WriteLine("RIGHT-DIAGONAL = {0:F2}", Math.Round(sumRightDiagonal,2));
            }

        }
    }
}
