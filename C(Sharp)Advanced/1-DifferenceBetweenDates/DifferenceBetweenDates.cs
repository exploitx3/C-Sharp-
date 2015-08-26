using System;


namespace _1_DifferenceBetweenDates
{
    class DifferenceBetweenDates
    {
        static void Main()
        {
            string[] dateStr = Console.ReadLine().Split('.');
            string[] dateStr2 = Console.ReadLine().Split('.');
            int[] dateMembers = new int[3];
            int[] dateMembers2 = new int[3];
            for (int i = 0; i < dateStr.Length; i++)
			{
			 dateMembers[i] = int.Parse(dateStr[i]);
             dateMembers2[i] = int.Parse(dateStr2[i]);
			}
            DateTime date = new DateTime(dateMembers[2], dateMembers[1], dateMembers[0]);
            DateTime date2 = new DateTime(dateMembers2[2], dateMembers2[1], dateMembers2[0]);
            TimeSpan between = date2.Subtract(date);
            
            
            Console.WriteLine(between.Days);
        }
    }
}
