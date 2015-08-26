using System;


namespace CompoundInterest
{
    class CompoundInterest
    {
        static void Main()
        {
            decimal priceTv = decimal.Parse(Console.ReadLine());
            int numberYears = int.Parse(Console.ReadLine());
            decimal interestRate = decimal.Parse(Console.ReadLine());
            decimal interestRateFrined = decimal.Parse(Console.ReadLine());
            double FV,FriendV;
            FV = (double)priceTv * Math.Pow(1+(double)interestRate, numberYears);
            FriendV = (double)priceTv * (1 + (double)interestRateFrined);
            if(FV<FriendV)
            {
                Console.Write(FV + " Bank");
            }
            else
            {
                Console.Write(FriendV + " Friend");
            }
            Console.WriteLine();
        }
    }
}
