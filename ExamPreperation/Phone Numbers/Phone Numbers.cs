using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Phone_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine;
            string fullText = "";
            while ((inputLine = Console.ReadLine()) != "END")
            {
                fullText += inputLine;
            }
            Regex pattern = new Regex(@"([A-Z][A-Za-z]*)[^A-Za-z\+]*?(?=\+|[0-9]{2})([0-9\+]{0,1}[\d][\d\s\/\.\(\)\-]*[0-9])");
            MatchCollection collection = pattern.Matches(fullText);
            
            if (collection.Count != 0)
            {
                for (int j = 0; j < collection.Count; j++)
                {
                    string value = collection[j].Groups[2].Value;
                    for (int i = 0; i < value.Length; i++)
                    {
                        switch (value[i])
                        {
                            case '(':
                                value = value.Replace("(", " ");
                                break;
                            case ')':
                                value = value.Replace(")", " ");
                                break;
                            case '/':
                                value = value.Replace("/", " ");
                                break;
                            case '.':
                                value = value.Replace(".", " ");
                                break;
                            case '-':
                                value = value.Replace("-", " ");
                                break;
                            case ' ':
                                value = value.Replace(" ", " ");
                                break;
                        }

                    }
                    value = value.Replace(" ", "");
                   
                        Console.Write((j == 0 ? "<ol>" : "") + "<li><b>" + collection[j].Groups[1].Value + ":</b>" + " " + value + "</li>" + (j == collection.Count-1 ? "</ol>" : ""));
                    
                   



                }
            }
            else
            {
                Console.WriteLine("<p>No matches!</p>");
            }

        }
    }
}
