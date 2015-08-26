using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneProcesses
{
    class PhoneProcesses
    {
        static void Main()
        {
            int startPercentage = int.Parse(Console.ReadLine().Replace("%",""));
            
            
            int endPercentage = startPercentage;
            string programs = Console.ReadLine();
            string currentPercentage = "0";
            
            int iCounter = 0;
            
            while(programs.ToUpper() != "END")
            {

                if (endPercentage > 15)
                {
                    string[] spPercentage = programs.Split('_');
                    currentPercentage = spPercentage[1].Replace("%", "");




                    endPercentage = endPercentage - int.Parse(currentPercentage);
                }
                else
                {
                    iCounter++;
                }
                programs = Console.ReadLine();
              }
            
            
            
            
              
         
            if(endPercentage<=0)
            {
                Console.WriteLine("Phone Off");
            }else if(endPercentage<=15)
            {
                Console.WriteLine("Connect charger -> {0}%", endPercentage);
                Console.WriteLine("Programs left -> {0}", iCounter);
            } else
            {
                
            
                Console.WriteLine("Successful complete -> {0}%", endPercentage);
                
            }
        }
    }
}
