using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] towns = { "Sofia", "Varna", "Pleven", "Ruse", "Bourgas" };
            var townPairs =
                from t1 in towns
                from t2 in towns
                select new { T1 = t1, T2 = t2 };
            foreach (var townPair in townPairs)
            {
                Console.WriteLine("({0}, {1})",
                    townPair.T1, townPair.T2);
            }


        }
    }
}
