using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Beers
{
    class Beers
    {
        static void Main(string[] args)
        {
            
            int beers = 0;
            string[] inputString = Console.ReadLine().Split(' ');
            while (inputString[0] != "End")
            {
                if (inputString[1] == "stacks")
                {
                    beers += int.Parse(inputString[0])*20;
                }
                else
                {
                    beers += int.Parse(inputString[0]);
                }
                inputString = Console.ReadLine().Split(' ');
            }
            Console.WriteLine("{0} stacks + {1} beers",beers/20,beers%20);
        }
    }
}
