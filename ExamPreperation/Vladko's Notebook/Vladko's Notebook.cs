using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vladko_s_Notebook
{
    class Sheets
    {
        public string Color { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public List<string> Oponents { get; set; }
        public int Losses { get; set; }
        public int Wins { get; set; }
        public int Rank { get; set; }

        public Sheets(string color, string name, string age)
        {
            Color = color;
            Name = name;
            Age = age;
        }

        public Sheets(string color)
        {
            Color = color;
            Wins = 0;
            Losses = 0;
            Oponents = new List<string>();
            Age = "";
            Name = "";
        }

        public double CalculateRank()
        {
            double rank = Math.Round(((Wins + 1d) / (double)(Losses + 1d)), 2);
            return rank;
        }
    }
    class Program
    {
        private static void Main(string[] args)
        {

            List<Sheets> sheetsList = new List<Sheets>();
            string[] str;
            while ((str = Console.ReadLine().Split('|'))[0] != "END")
            {
                bool contains = false;
                foreach (Sheets sheet in sheetsList)
                {
                    if (sheet.Color == str[0])
                    {
                        contains = true;
                    }
                }
                if (!contains)
                {
                    sheetsList.Add(new Sheets(str[0]));
                }
                switch (str[1])
                {
                    case "win":
                        foreach (Sheets sheet in sheetsList)
                        {
                            if (sheet.Color == str[0])
                            {
                                sheet.Wins++;
                                sheet.Oponents.Add(str[2]);
                            }
                        }

                        break;
                    case "loss":
                        foreach (Sheets sheet in sheetsList)
                        {
                            if (sheet.Color == str[0])
                            {
                                sheet.Losses++;
                                sheet.Oponents.Add(str[2]);
                            }
                        }
                        break;
                    case "age":
                        foreach (Sheets sheet in sheetsList)
                        {
                            if (sheet.Color == str[0])
                            {
                                sheet.Age = str[2];
                            }
                        }
                        break;
                    case "name":
                        foreach (Sheets sheet in sheetsList)
                        {
                            if (sheet.Color == str[0])
                            {
                                sheet.Name = str[2];
                            }
                        }
                        break;
                }
            }
            sheetsList = sheetsList.OrderBy(sheet => sheet.Color).ToList();
            bool hasRecoverdData = false;
            foreach (Sheets sheet in sheetsList)
            {
                if (sheet.Age != "" && sheet.Name != "")
                {
                    sheet.Oponents = sheet.Oponents.OrderBy(p => p, StringComparer.Ordinal).ToList();
                    Console.WriteLine("Color: {0}", sheet.Color);
                    Console.WriteLine("-age: {0}", sheet.Age);
                    Console.WriteLine("-name: {0}", sheet.Name);
                    Console.WriteLine("-opponents: {0}", sheet.Oponents.Count == 0 ? "(empty)" : String.Join(", ", sheet.Oponents));
                    Console.WriteLine("-rank: {0:F2}", sheet.CalculateRank());
                    hasRecoverdData = true;
                }

            }
            if (!hasRecoverdData)
            {
                Console.WriteLine("No data recovered.");
            }
        }
    }
}

