using System;

namespace OddEvenSum
{
    class OddEvenSum
    {
        static void Main()
        {
            int sumOdd = 0;
            int sumEven = 0;
            int number = 0;
            int n;
            do
            {
                Console.Write("n= ");
                 n = int.Parse(Console.ReadLine());
            } while (n < 0 || n > 500);
            for (int i = 1; i <= n*2; i++)
            {
                do
                {
                    
                    Console.Write("Number= ");
                    number = int.Parse(Console.ReadLine());
                    if(number < -500000 || number > 500000)
                    {
                        Console.WriteLine("The number must be bigger than -500 000 and less than 500 000!");
                    }
                } while (number < -500000 || number > 500000);
                if(number % 2 == 0)
                {
                    sumEven += number;
                }
                if(number % 2 != 0)
                {
                    sumOdd += number;
                }
            }
            if(sumOdd == sumEven)
            {
                Console.WriteLine("Yes, sum=" + sumOdd);
            }
            else if(sumOdd > sumEven)
            {
                Console.WriteLine("No,diff=" + (sumOdd - sumEven));
            }
            else if (sumOdd < sumEven)
            {
                Console.WriteLine("No,diff=" + (sumEven - sumOdd));
            }

        }
    }
}
