using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;

namespace Chat_Logger
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] inputDate = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string[] dateFirstPart = inputDate[0].Split(new char[] {'-'}, StringSplitOptions.RemoveEmptyEntries);
            string[] dateSecondPart = inputDate[1].Split(new char[] {':'}, StringSplitOptions.RemoveEmptyEntries);
            int year = int.Parse(dateFirstPart[2]);
            int month = int.Parse(dateFirstPart[1]);
            int day = int.Parse(dateFirstPart[0]);
            int hours = int.Parse(dateSecondPart[0]);
            int minutes = int.Parse(dateSecondPart[1]);
            int seconds = int.Parse(dateSecondPart[2]);
            DateTime currentDate = new DateTime(year, month, day, hours, minutes, seconds);
            List<DateTime> dates = new List<DateTime>();
            Dictionary<string, DateTime> messages = new Dictionary<string, DateTime>();
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                MatchCollection collection = Regex.Matches(input,
                    @"(.*?)\s*?\/\s*?(\d\d)-(\d\d)-(\d\d\d\d)\s*?(\d\d):(\d\d):(\d\d)");
                for (int i = 0; i < collection.Count; i++)
                {
                    string message = collection[i].Groups[1].Value;
                    year = int.Parse(collection[i].Groups[4].Value);
                    month = int.Parse(collection[i].Groups[3].Value);
                    day = int.Parse(collection[i].Groups[2].Value);
                    hours = int.Parse(collection[i].Groups[5].Value);
                    minutes = int.Parse(collection[i].Groups[6].Value);
                    seconds = int.Parse(collection[i].Groups[7].Value);
                    dates.Add(new DateTime(year, month, day, hours, minutes, seconds, DateTimeKind.Local));
                    messages.Add(message, new DateTime(year, month, day, hours, minutes, seconds, DateTimeKind.Local));
                }
            }


            DateTime lastMessageDate = dates.Max();
            TimeSpan span = currentDate.Subtract(lastMessageDate);
            string spanMessage = "";






            if (span < new TimeSpan(0, 0, 1, 0))
            {
                spanMessage = System.Security.SecurityElement.Escape("a few moments ago");
            }
            else
            {
                if (span < new TimeSpan(0, 1, 0, 0))
                {
                    spanMessage =
                        System.Security.SecurityElement.Escape(string.Format("{0} minute(s) ago", span.Minutes));
                }
                else
                {
                    if (span < new TimeSpan(0, 24, 0, 0))
                    {
                        if ((currentDate - span).Day - currentDate.Day == -1)
                        {
                            spanMessage = System.Security.SecurityElement.Escape("yesterday");
                        }
                        else
                        {
                            if ((currentDate - span).Day - currentDate.Day < -1)
                            {
                                DateTime tempTime = currentDate - currentDate.Subtract(lastMessageDate);
                                spanMessage =
                                    System.Security.SecurityElement.Escape(string.Format("{0:dd-MM-YYYY}", tempTime));
                            }
                            else
                            {
                                spanMessage =
                                    System.Security.SecurityElement.Escape(string.Format("{0} hour(s) ago",
                                        span.Hours));
                            }
                        }
                    }
                }
            }
            if ((currentDate - span).Day - currentDate.Day == -1)
            {
                spanMessage = System.Security.SecurityElement.Escape("yesterday");
            }
            else
            {
                if ((currentDate - span).Day - currentDate.Day < -1)
                {
                    DateTime tempTime = currentDate - currentDate.Subtract(lastMessageDate);
                    spanMessage =
                        System.Security.SecurityElement.Escape(string.Format("{0:dd-MM-yyyy}", tempTime));
                }
                else
                {
                    if (spanMessage == "")
                    {
                        spanMessage =
                            System.Security.SecurityElement.Escape(string.Format("{0} hour(s) ago",
                                span.Hours));
                    }
                }
            }







            var finalMessages = messages.OrderBy(p => p.Value);
                foreach (var key in finalMessages)
                {
                    Console.WriteLine("<div>" + System.Security.SecurityElement.Escape(key.Key) + "</div>");
                }
                Console.WriteLine("<p>Last active: <time>{0}</time></p>", spanMessage);
            }
        }
    }
