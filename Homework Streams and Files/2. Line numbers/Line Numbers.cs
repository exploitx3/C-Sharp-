using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _2.Line_numbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../textFile.txt");
            StreamWriter writer = new StreamWriter("../../newTextFile.txt");
            try
            {
               
                string line = reader.ReadLine();
                int counter = 1;
                while (line != null)
                {
                    writer.WriteLine(counter + " " + line);
                    line = reader.ReadLine();
                    counter++;
                }
            }
            finally
            {
                writer.Flush();
                reader.Dispose();
                writer.Dispose();
            }
        }
    }
}
