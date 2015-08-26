using System;


namespace PrimeNumberCheck
{
    class PrimeNumberCheck
    {
      static bool isPrime(int num)
        {
            bool ch = false;
            if (num == 2)
            {
                
                return true;
            }
                for (int i = 2; i < num; i++)
            {
                if (num % i != 0)
                {
                    ch = true;

                }
                else
                {
                    return false;
                }

            }
                return ch;
        }
        static void Main()
        {
            int num = 0;
            bool check = false;
            do
            {

                Console.Write("n= ");
                num = int.Parse(Console.ReadLine());
                if (num > 100 || num <= 0)
                {
                    Console.WriteLine("n should be a positive number and less or equal 100.");
                }
            }
            while (num > 100 || num <= 0);



            Console.WriteLine(isPrime(num));
            }
        }
    
}