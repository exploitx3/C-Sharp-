using System;

namespace Volleyball
{
    class Volleyball
    {
        static void Main()
        {
            Console.Write("year= ");
            string year = Console.ReadLine();
            double p, h;

            do
            {
                Console.Write("p= ");
                p = double.Parse(Console.ReadLine());
                Console.Write("h= ");
                h = double.Parse(Console.ReadLine());
            } while (p < 0 || p > 300 || h < 0 || h > 48);
            int result;
      
            if(year == "leap")
            {
                result = (int)(((h + ((48 - h) * (0.75))) + (p * (0.66))) + ((((h + ((48 - h) * (0.75))) + (p * (0.66))) * 15) / 100));
            

                Console.WriteLine(result);


            }else if(year == "normal")
            {
                result = (int)(h + ((48 - h) * (0.75)) + (p * 0.66));
                Console.WriteLine(result);

            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            
        }
    }
}
