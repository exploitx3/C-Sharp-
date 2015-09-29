using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DailyCalorieIntake
{
    class DailyCalorieIntake
    {
        static void Main(string[] args)
        {
            int weightInPounds = int.Parse(Console.ReadLine());
            int heightInInches = int.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int workoutsPerWeek = int.Parse(Console.ReadLine());
           
            double weightInKilos = weightInPounds / 2.2d;
            double heightInCm = heightInInches * 2.54d;

            double bmrM =   66.5d + (13.75d * weightInKilos) + (5.003d * heightInCm) - (6.755d * age);
            double bmrW = 655 + (9.563d * weightInKilos) + (1.850d * heightInCm) - (4.676d * age);

            double dci;
            if (workoutsPerWeek <= 0 )
            {
                dci = 1.2d;
            }
            else if (workoutsPerWeek >= 1 && workoutsPerWeek <=3)
            {
                dci = 1.375d;
            }
            else if (workoutsPerWeek >= 4 && workoutsPerWeek <= 6)
            {
                dci = 1.55d;
            }
            else if (workoutsPerWeek >= 7 && workoutsPerWeek <= 9)
            {
                dci = 1.725d;
            }
            else
            {
                dci = 1.9d;
            }
             if (gender == 'm')
            {
              Console.WriteLine(Math.Floor(bmrM * dci));
            }
            else
            {
                Console.WriteLine(Math.Floor(bmrW * dci));
            }
           
        }
    }
}
/*
154
70
27
m
0
130
63
21
f
7
 * 
summer!!ends#
*/