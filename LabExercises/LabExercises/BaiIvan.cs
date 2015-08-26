using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExercises
{
    class BaiIvan
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            double baiIvansMoney = double.Parse(Console.ReadLine());
            double litersHappy = double.Parse(Console.ReadLine());
            double alcoholCost = 0;
            
            switch (day)
            {
                case 0:
                    alcoholCost = 25;
                    break;
                case 1:
                    alcoholCost = 21;
                    break;
                case 2:
                    alcoholCost = 14;
                    break;
                case 3:
                    alcoholCost = 17;
                    break;
                case 4:
                    alcoholCost = 45;
                    break;
                case 5:
                    alcoholCost = 59;
                    break;
                case 6:
                    alcoholCost = 42;
                    break;
                default:
                    break;
            }
            double baiIvansAlcohol = baiIvansMoney / alcoholCost;
            string baiIvansCondition = "";
            if(baiIvansAlcohol>1.5)
            {
                baiIvansCondition = "very drunk";
            }else if(baiIvansAlcohol <= 1.5 && baiIvansAlcohol>=1.00)
            {
                baiIvansCondition = "drunk";
            }else
            {
                baiIvansCondition = "sober";
            }
            if(baiIvansAlcohol > litersHappy)
            {
                Console.WriteLine("Bai Ivan is {0} and very happy and he shared {1:F2} l. of alcohol with his friends",baiIvansCondition,baiIvansAlcohol-litersHappy);
            }else if(baiIvansAlcohol == litersHappy)
            {
                Console.WriteLine("Bai Ivan is {0} and happy. He is as drunk as he wanted",baiIvansCondition);
            }else
            {
                Console.WriteLine("Bai Ivan is {0} and quite sad. He wanted to drink another {1:F2} l. of alcohol",baiIvansCondition,litersHappy - baiIvansAlcohol);
            }
 
        }
    }
}
