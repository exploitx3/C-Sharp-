using System;


namespace BeerTime
{
    class BeerTime
    {
        static void Main()
        {
            int hour;
            int min;
            string designator;

            do
            {
                Console.Write("Hour: ");
                hour = int.Parse(Console.ReadLine());
                Console.Write("Minutes: ");
                min = int.Parse(Console.ReadLine());
                Console.Write("Designator(AM or PM): ");
                designator = Console.ReadLine();
                if (hour < 1 || hour > 12 || min < 0 || min > 59 || (designator != "AM" && designator != "PM"))
                {
                    Console.WriteLine("Hour must be from 1 to 12,minutes from 0 to 59 and the time designator must be either AM or PM");
                }
            } while (hour < 1 || hour > 12 || min < 0 || min > 59 || (designator != "AM" && designator != "PM"));
           
            
            string strDate = string.Format("{0}:{1:00} {2}", hour, min, designator);
            
            
            DateTime beerTime1 = DateTime.Parse("1:00 PM");
            DateTime beerTime2 = DateTime.Parse("3:00 AM");
            DateTime stonerTime1 = DateTime.Parse("4:20 AM");
            DateTime stonerTime2 = DateTime.Parse("4:20 PM");

            DateTime date = new DateTime();
            bool validDate = DateTime.TryParse(strDate, out date);
            if (validDate)
            {
                if(designator == "PM")
                {
                    if (DateTime.Compare(date, stonerTime2) == 0)
                    {
                        Console.WriteLine(strDate + " - stoner time");
                    }else if (DateTime.Compare(date, beerTime1) >= 0)
                    {
                        Console.WriteLine(strDate + " - beer time");
                    }else
                    {
                        Console.WriteLine(strDate + " - non-beer time");
                    }
                }
                if (designator == "AM")
                {
                    if (DateTime.Compare(date, stonerTime1) == 0)
                    {
                        Console.WriteLine(strDate + " - stoner time");
                    }else if (DateTime.Compare(date, beerTime2) < 0)
                    {
                        Console.WriteLine(strDate + " - beer time");
                    }else
                    {
                        Console.WriteLine(strDate + " - non-beer time");
                    }
                }
             
               
            }
            else
            {
                Console.WriteLine("Invalid Date");
            }
          
        }
    }
}
