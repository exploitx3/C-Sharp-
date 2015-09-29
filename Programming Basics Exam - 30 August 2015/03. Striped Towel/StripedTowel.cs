using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _03.Striped_Towel
{
    internal class StripedTowel
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = n ;
            

            int height = (int)(n*1.50);
            


            
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    
                    if ((j+i) % 3 == 0)
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
