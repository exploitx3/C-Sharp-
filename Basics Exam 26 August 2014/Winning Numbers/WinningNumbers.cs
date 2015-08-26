using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winning_Numbers
{
    class WinningNumbers
    {
        static int CalculateLetter(char ch)
        {
            if(ch >= 'a' && ch <= 'z')
            {
                return (int)ch - 96;
            }else if(ch >= 'A' && ch <= 'Z')
            {
                return (int)ch - 64;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            string strInput = Console.ReadLine();
            int sum = 0;
            bool hasFound = false;
            for (int i = 0; i < strInput.Length; i++)
            {
                sum += CalculateLetter(strInput[i]);
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        for (int l = 0; l < 10; l++)
                        {
                            for (int m = 0; m < 10; m++)
                            {
                                for (int n = 0; n < 10; n++)
                                {
                                    if(i*j*k == l*n*m && i*j*k == sum)
                                    {
                                        Console.WriteLine("{0}{1}{2}-{3}{4}{5}",i,j,k,l,m,n);
                                        hasFound = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if(!hasFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}
