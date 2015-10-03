using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _3.Word_Count
{
    internal class Program
    {
        private static void Main(string[] args)
        {
             StreamReader reader = new StreamReader("../../wordFile.txt");
             StreamReader readerSearchFile = new StreamReader("../../textFile.txt");
             StreamWriter writer = new StreamWriter("../../resultFile.txt");
            try
            {
               
                SortedDictionary<String, int> words = new SortedDictionary<string, int>();
                string word = reader.ReadLine();
                string textFile = readerSearchFile.ReadToEnd().ToLower();
                while (word != null)
                {
                    word = word.ToLower();
                   
                    string pattern = @"\b" + word + @"\b";
                    MatchCollection matches = Regex.Matches(textFile, pattern);
                    words.Add(word, matches.Count);
                    word = reader.ReadLine();
                  
                    
                }
                var ordered = words.OrderByDescending(pair => pair.Value);
                foreach (KeyValuePair<string, int> pair in ordered)
                {
                    writer.WriteLine("{0} - {1}", pair.Key, pair.Value);
                }
            }
            finally
            {
                writer.Flush();
                reader.Dispose();
                readerSearchFile.Dispose();
                writer.Dispose();
            }
            
        }
    }
}
