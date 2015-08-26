using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsAtCrossroads
{
    class BitsAtCrossroads
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sizeN = n * n;
            char[,] board = new char[n, n];
            int[,] intArr = new int[n, n];
            int count = 0;
            string[] crossroads = Console.ReadLine().Split(' ');
            while (crossroads[0].ToLower() != "end")
            {
                intArr[count, 0] = int.Parse(crossroads[0]);
                intArr[count, 1] = int.Parse(crossroads[1]);
                count++;
                crossroads = Console.ReadLine().Split(' ');
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    board[i, j] = '0';
                }
            }
            int sumCross = count;
            for (int crossRoad = 0; crossRoad < count; crossRoad++)
            {
                int counter = 0;
                for (int query = 0; query < n; query++)
                {


                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if ((i == intArr[crossRoad, 0] - counter && j == intArr[crossRoad, 1] + counter) || (i == intArr[crossRoad, 0] - counter && j == intArr[crossRoad, 1] - counter) || (i == intArr[crossRoad, 0] + counter && j == intArr[crossRoad, 1] + counter) || (i == intArr[crossRoad, 0] + counter && j == intArr[crossRoad,1] - counter))
                            {
                                if(board[i, n-j-1] == '1')
                                {
                                   
                                    sumCross++;
                                }
                                board[i, n-j-1] = '1';
                            }
                            
                        }

                    }
                    counter++;
                }
            }
            
            for (int i = 0; i < n; i++)
            {
                StringBuilder newStr = new StringBuilder();
                for (int j = 0; j < n; j++)
                {
                    
                    newStr.Append(board[i,j]);
                }
                string bits = newStr.ToString().PadLeft(n,'0');
                Console.WriteLine(Convert.ToInt64(bits,2));
            }
            Console.WriteLine(sumCross);

        }
    }
}
