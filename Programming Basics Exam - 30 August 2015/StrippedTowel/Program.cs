using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrippedTowel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = n;
            int height = (int)(n * 1.50);

 

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {

                    if ((i+j) % 7 == 0)
                    {
                        Console.Write('#');

                    }
                    else
                    {

                        Console.Write('.');
                    }
                }
                
                Console.WriteLine();


            }




        }
    }
}
