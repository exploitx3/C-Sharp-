//using System;

//namespace Test
//{
//    class MagicDates
//    {
//        static void Main()
//        {
//            int startYear = int.Parse(Console.ReadLine());
//            int endYear = int.Parse(Console.ReadLine());
//            int magicWeight = int.Parse(Console.ReadLine());
//            DateTime firstYear = new DateTime(startYear, 1, 1);
//            DateTime secondYear = new DateTime(endYear, 1, 1);
//            bool hasFound = false;

//            while (startYear <= endYear)
//            {
//                for (int month = 1; month <= 12; month++)
//                {
//                    int daysInMonth = DateTime.DaysInMonth(startYear, month);
//                    for (int days = 1; days <= daysInMonth; days++)
//                    {
//                        int sum = 0;
//                        string dates = null;
                       
//                        dates += days + "" + month + "" + startYear;
//                        for (int i = 0; i < dates.Length; i++)
//                        {
                           
//                            for (int j = i+1; j < dates.Length; j++)
//                            {
//                                sum += (int)(dates[i]-'0') * (int)(dates[j]-'0');
//                            }
//                        }
//                        if(sum==magicWeight)
//                        {
//                            DateTime tempDate = new DateTime(startYear, month, days);
//                            Console.WriteLine("{0:dd-MM-yyyy}",tempDate);
//                            hasFound = true;
//                        }
                        
                        
//                    }
//                }
//                startYear++;
//            }
//            if(!hasFound)
//            {
//                Console.WriteLine("No");
//            }

//        }
//    }
//}
using System;

public class MagicDates
{
    public static void Main()
    {
        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int magicWeight = int.Parse(Console.ReadLine());

        DateTime startDate = new DateTime(startYear, 1, 1);
        DateTime endDate = new DateTime(endYear, 12, 31);
        bool hasFound = false;
        for (DateTime d = startDate; d <= endDate; d = d.AddDays(1))
        {
            int sum = 0;
            string temp = d.Day + "" + d.Month + "" +d.Year;
              for (int i = 0; i < temp.Length; i++)
              {

                  for (int j = i + 1; j < temp.Length; j++)
                  {
                      sum += (int)(temp[i] - '0') * (int)(temp[j] - '0');
                  }
              }
            if(sum==magicWeight)
            {
                hasFound = true;
                Console.WriteLine("{0:dd-MM-yyyy}",d);
            }
        }
        if(!hasFound)
        {
            Console.WriteLine("No");
        }
    }
}




