using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tables
{
    class Tables
    {
        static void Main(string[] args)
        {
            long firstBundle = long.Parse(Console.ReadLine());
            long secondBundle = long.Parse(Console.ReadLine());
            long thirdBundle = long.Parse(Console.ReadLine());
            long fourthBundle = long.Parse(Console.ReadLine());
            long tableTops = long.Parse(Console.ReadLine());
            long tablesToBeMade = long.Parse(Console.ReadLine());
            long allLegs = (firstBundle * 1) + (secondBundle * 2) + (thirdBundle * 3) + (fourthBundle * 4);
            long legsToBeMade = tablesToBeMade * 4;
            long tableTopsToBeMade = tablesToBeMade;
            long tables = allLegs / 4;
           
            if(allLegs/4 > tableTops)
            {
                tables = tableTops;
                
            }else if(tableTops> allLegs/4)
            {
                tables = allLegs / 4;
              
            }
            long legsNeeded = legsToBeMade-allLegs;
            long topsNeeded = tableTopsToBeMade-tableTops;
            if(tableTopsToBeMade-tableTops<=0)
            {
                topsNeeded = 0;
            }
            if(legsToBeMade-allLegs<=0)
            {
                legsNeeded = 0;
            }
            if(tables > tablesToBeMade)
            {
                Console.WriteLine("more: {0}",tables-tablesToBeMade);
                Console.WriteLine("tops left: {0}, legs left: {1}",tableTops-tableTopsToBeMade,allLegs - legsToBeMade);
            }else if(tables<tableTopsToBeMade)
            {
                Console.WriteLine("less: {0}",tables-tablesToBeMade);
                Console.WriteLine("tops needed: {0}, legs needed: {1}",tableTopsToBeMade-tableTops,legsNeeded );
            }else if(tables == tablesToBeMade)
            {
                Console.WriteLine("Just enough tables made: {0}",tables);
            }
        }
    }
}
