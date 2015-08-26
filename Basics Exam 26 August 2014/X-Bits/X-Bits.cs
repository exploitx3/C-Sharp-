using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strNumbers = new string[8];
            int xCounter = 0;
            for (int i = 0; i < 8; i++)
            {
                int number = int.Parse(Console.ReadLine());
                strNumbers[i] = Convert.ToString(number, 2).PadLeft(32,'0');
            }
            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < 31; j++)
                {
                    bool first = (strNumbers[i - 1][j - 1] == '1' && strNumbers[i - 1][j] == '0' && strNumbers[i - 1][j + 1] == '1');
                    bool second = (strNumbers[i][j-1] == '0' && strNumbers[i][j] == '1' && strNumbers[i][j+1] == '0');
                    bool third = (strNumbers[i+1][j-1] == '1' && strNumbers[i+1][j] == '0' && strNumbers[i+1][j+1] == '1');
                    if(first && second  && third)                        
                    {
                        xCounter++;
                    }
                }
            }
            Console.WriteLine(xCounter);
            
            

        }
    }
}
