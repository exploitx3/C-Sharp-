using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOrders
{
    class BookOrders
    {
        static int CalculateDiscount(double x)
        {
            if(x>=10 && x<=19)
            {
                return 5;
            }else if(x>=20 && x<=29)
            {
                return 6;
            }else if(x>=30 && x<=39)
            {
                return 7;
            }else if(x >= 40 && x<=49)
            {
                return 8;
            }
            else if (x >= 50 && x <= 59)
            {
                return 9;
            }
            else if (x >= 60 && x <= 69)
            {
                return 10;
            }
            else if (x >= 70 && x <= 79)
            {
                return 11;
            }
            else if (x >= 80 && x <= 89)
            {
                return 12;
            }
            else if (x >= 90 && x <= 99)
            {
                return 13;
            }
            else if (x >= 100 && x <= 109)
            {
                return 14;
            }else if(x>=110)
            {
                return 15;
            }else
            {
                return 0;
            }

        }
        static void Main(string[] args)
        {
            int bookOrders = int.Parse(Console.ReadLine());
            double[,] ordersArr = new double[bookOrders, 3];
            double sum = 0;
            double booksSum = 0;
            for (int i = 0; i < bookOrders; i++)
            {
                
                for (int j = 0; j < 3; j++)
			    {
                  ordersArr[i, j] = double.Parse(Console.ReadLine());
		    	}
                sum += (ordersArr[i, 0] * ordersArr[i, 1]) * (ordersArr[i, 2] - ((ordersArr[i, 2] * CalculateDiscount(ordersArr[i, 0])) / 100));
                booksSum += (ordersArr[i, 0] * ordersArr[i, 1]);
            }
            
            Console.WriteLine(booksSum);
            Console.WriteLine("{0:F2}",sum);



        }
    }
}
