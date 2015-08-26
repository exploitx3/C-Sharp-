using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int num = int.Parse(Console.ReadLine());
            int[] arrCounter = new int[num];
            for (int i = 0; i < num; i++)
            {
                counter = 0;
                string strN = Console.ReadLine();
                int n = int.Parse(strN);
                
               
                for (int j = 0; j < strN.Length; j++)
                {
                    int number = Convert.ToInt32(strN[j] - '0');

                   if(number!=0)
                   {
                       if (n % number == 0 || number == 1)
                       {
                           counter++;
                       }
                   }
                }
                arrCounter[i] = counter;
  
            }

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(arrCounter[i]);
            }
        }
    }
}
