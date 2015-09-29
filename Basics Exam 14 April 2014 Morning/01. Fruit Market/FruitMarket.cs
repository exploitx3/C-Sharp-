using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fruit_Market
{
    class FruitMarket
    {
        static void Main(string[] args)
        {
            double banana  =  1.80;
            double cucumber=  2.75;
            double tomato  =  3.20;
            double orange  =  1.60;
            double apple = 0.86;
            string dayOfWeek = Console.ReadLine();
            double percentDiscount = 0;
            switch (dayOfWeek)
            {
                case "Friday":
                    percentDiscount = 0.10;
                    break;
                case "Sunday":
                    percentDiscount = 0.05;
                    break;
                case "Tuesday":

                    banana = banana - (banana * 0.20);
                    orange = orange - (orange * 0.20);
                    apple = apple - (apple * 0.20);
                    
                    break;
                case "Wednesday":
                    cucumber = cucumber - (cucumber*0.10);
                    tomato = tomato - (tomato*0.10);
                    break;
                case "Thursday":
                    banana = banana - (banana * 0.30);
                    break;
                default:
                    break;
            }
            double sum = 0;
            for (int i = 0; i < 3; i++)
            {
                double currentQuantity = double.Parse(Console.ReadLine());
                string currentProduct = Console.ReadLine();
                
                switch (currentProduct)
                {
                    case "banana":
                        sum += currentQuantity*banana;
                        break;
                    case "cucumber":
                        sum += currentQuantity * cucumber;
                        break;
                    case "tomato":
                        sum += currentQuantity * tomato;
                        break;
                    case "orange":
                        sum += currentQuantity * orange;
                        break;
                    case "apple":
                        sum += currentQuantity * apple;
                        break;
                    default:
                        break;
                 }
            }
            sum = sum - (sum*percentDiscount);
            Console.WriteLine("{0:F2}",sum);
           
        }
    }
}
