using System;

namespace TheExplorer
{
    class TheExplorer
    {
        static void Main()
        {
            int width = 0;
            try
            {
                do
                {
                    Console.Write("width= ");
                    width = int.Parse(Console.ReadLine());
                    if (width < 3 || width > 59 || width % 2 == 0)
                    {
                        Console.WriteLine("The number n must be a positive odd integer between 3 and 59");
                    }
                } while (width < 3 || width > 59 || width % 2 == 0);
            }catch(Exception)
            {
                Console.WriteLine("Error!");
            }
            int height = width;
            int lowerNumber = width / 2;
            int higherNumber = width / 2;

            for (int i = 0; i < height; i++)
			{
			 for(int j = 0; j < width;j++)
               {
                 if(i==0 && j == height/2)
                 {
                     Console.Write("*");
                 }else if(i>0 && j == lowerNumber)
                 {
                     Console.Write("*");
                 }else if(i>0 && j == higherNumber)
                 {
                     Console.Write("*");
                 }else
                 {
                     Console.Write("-");
                 }
                }
             Console.WriteLine();
                if(i<width/2)
                {
                    lowerNumber--;
                    higherNumber++;
                }
                else
                {
                    lowerNumber++;
                    higherNumber--;
                }
			}
         }

    }
}