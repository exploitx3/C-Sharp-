using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDowns
{
    class DoubleDowns
    {
        static void Main(string[] args)
        {
            int numIntegers = int.Parse(Console.ReadLine());
            string[] integersStr = new string[numIntegers];
            int rightCounter = 0;
            int leftCounter = 0;
            int verticalCounter = 0;
            for (int i = 0; i < numIntegers; i++)
            {                
                integersStr[i] = Convert.ToString((int.Parse(Console.ReadLine())),2).PadLeft(32,'0');
            }
            for (int i = 0; i < integersStr.Length-1; i++)
            {
                
                for (int j = 0; j < 32; j++)
                {
                    if (integersStr[i][j] == '1' && integersStr[i + 1][j] == '1')
                    {
                        verticalCounter++;
                    }
                    if (j == 0)
                    {
                        if (integersStr[i][j] == '1' && integersStr[i + 1][j + 1] == '1')
                        {
                            rightCounter++;
                        }
                    }else if(j==31)
                    {
                        if (integersStr[i][j] == '1' && integersStr[i + 1][j - 1] == '1')
                        {
                            leftCounter++;
                        }
                    }else
                    {
                        if (integersStr[i][j] == '1' && integersStr[i + 1][j + 1] == '1')
                        {
                            rightCounter++;
                        }
                        if(integersStr[i][j]=='1' && integersStr[i+1][j-1] == '1')
                        {
                            leftCounter++;
                        }
                    }

                }
            }
            Console.WriteLine(rightCounter);
            Console.WriteLine(leftCounter);
            Console.WriteLine(verticalCounter);

        }
    }
}
