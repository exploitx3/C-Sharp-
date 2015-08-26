using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam26AprilMorning
{
    class BookProblem
    {
        static void Main()
        {
            int numPages = int.Parse(Console.ReadLine());
            int numCampDays = int.Parse(Console.ReadLine());
            int numPagesRead = int.Parse(Console.ReadLine());
            if (numCampDays >= 30)
            {
                Console.WriteLine("never");
            }
            else
            {
                int oneMonth = (30 - numCampDays) * numPagesRead;
                int Years = (numPages / oneMonth) / 12;
                double  Months =(double)(((double)numPages / oneMonth) % 12);
               
                
                Console.WriteLine("{0} years {1} months", Years,  Math.Ceiling(Months));
            }
          
            
            
        }
    }
}
