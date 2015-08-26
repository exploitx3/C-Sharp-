using System;


namespace _20_ExamSchedule
{
    class ExamSchedule
    {
        static void Main()
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            string part_Of_Day = Console.ReadLine();
            int hour_Duration = int.Parse(Console.ReadLine());
            int minutes_Duration = int.Parse(Console.ReadLine());
            if(part_Of_Day == "PM")
            {
                hour += 12;
                if(hour == 24)
                {
                    hour = 0;
                }
            }
            DateTime start = new DateTime(2015, 1, 15, hour, minutes,0);
            DateTime end = start.AddHours(hour_Duration).AddMinutes(minutes_Duration);
            
            Console.WriteLine("{0:hh:mm:tt}",end);

        }
    }
}
