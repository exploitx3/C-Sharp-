using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Simple_Calculation
{
    class Simple_Calculation
    {
        static void Main(string[] args)
        {
            double inputX = double.Parse(Console.ReadLine());
            double inputY = double.Parse(Console.ReadLine());
            if (inputX > 0 && inputY > 0)
            {
                Console.WriteLine(1);
            }else if (inputX < 0 && inputY > 0)
            {
                Console.WriteLine(2);
            }
            else if(inputX < 0 && inputY < 0)
            {
                Console.WriteLine(3);
            }else if (inputX > 0 && inputY < 0)
            {
                Console.WriteLine(4);
            }
            else if(inputX == 0 && inputY!=0)
            {
                Console.WriteLine(5);
            }else if (inputY == 0 && inputX !=0)
            {
                Console.WriteLine(6);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
