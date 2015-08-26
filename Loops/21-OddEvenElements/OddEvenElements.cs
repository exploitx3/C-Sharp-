using System;


namespace _21_OddEvenElements
{
    class OddEvenElements
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');
            decimal[] decimalArr = new decimal[numbers.Length];
            if(numbers[0] == "")
            {
                decimalArr = new decimal[0];
            }
            else
            {
                 decimalArr = new decimal[numbers.Length];
                      for (int i = 0; i < numbers.Length; i++)
                      {
                         decimalArr[i] = decimal.Parse(numbers[i]);
                      }
            }
      
            decimal oddSum = 0;
            decimal oddMin = decimal.MaxValue;
            decimal oddMax = decimal.MinValue;
            decimal evenSum = 0;
            decimal evenMin = decimal.MaxValue;
            decimal evenMax = decimal.MinValue;
            for (int i = 0,j = 1; i < decimalArr.Length; i++,j++)
            {
                if(j%2==1)
                {
                    oddMin = Math.Min(oddMin, decimalArr[i]);
                    oddMax = Math.Max(oddMax, decimalArr[i]);
                    oddSum += decimalArr[i];
                }
                if(j%2 == 0)
                {
                    evenMin = Math.Min(evenMin, decimalArr[i]);
                    evenMax = Math.Max(evenMax, decimalArr[i]);
                    evenSum += decimalArr[i];
                }
            }
            if(decimalArr.Length == 0)
            {
                Console.Write("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
                Console.WriteLine();
            }
            if(decimalArr.Length == 1)
            {
                Console.Write("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No", (double)oddSum, (double)oddMin, (double)oddMax);
                Console.WriteLine();
            }
            if(decimalArr.Length > 1)
            {
                Console.Write("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", (double)oddSum, (double)oddMin, (double)oddMax, (double)evenSum, (double)evenMin, (double)evenMax);
                 Console.WriteLine();
            }
        


        }
    }
}