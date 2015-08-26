using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LonelyInteger
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split(' ');
            int[] intArr = new int[n];
            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = int.Parse(str[i]);
            }
            int lonelyNumber = 0;
            int[] intArrHelp = intArr;
            for (int i = 0; i < intArr.Length; i++)
            {
                intArrHelp = intArr;
                int number = intArrHelp[i];
                int counter = 0;
                for (int j = 0; j < intArr.Length; j++)
                {
                    if (intArrHelp[j] == number)
                    {
                        
                        counter++;
                    }
                }
                
               
                if (counter == 1)
                {
                    lonelyNumber = intArrHelp[i];
                }

            }
            
            Console.WriteLine(lonelyNumber);
        }
    }
}
