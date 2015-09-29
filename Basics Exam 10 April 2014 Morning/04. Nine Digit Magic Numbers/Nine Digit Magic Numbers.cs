using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Nine_Digit_Magic_Numbers
{
    class Program
    {
        static bool IsValidNumber(int num)
        {
            int remainer = 0;
            while (num > 0)
            {
                remainer = num%10;
                num /= 10;
                if (remainer < 1 || remainer > 7)
                {
                    return false;
                }
            }
            return true;
        }

        static int CalculateSum(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result += num%10;
                num /= 10;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            bool hasNotFound = true;
            for (int abc = 111; abc <= 777; abc++)
            {
                int def = abc + diff;
                int ghi = def + diff;
                if (IsValidNumber(abc) && IsValidNumber(def) && IsValidNumber(ghi) && ghi <= 777 &&
                    (CalculateSum(abc) + CalculateSum(def) + CalculateSum(ghi)) == sum)
                {
                    Console.WriteLine(abc + "" + def + "" + ghi);
                    hasNotFound = false;
                }
            }
            if (hasNotFound)
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
