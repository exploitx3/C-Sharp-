using System;
using System.Collections.Generic;


namespace Text_Gravity
{
    class Program
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            string strInput = Console.ReadLine();
            List<string> stringsList = new List<string>();
            int counter = 0;
            
            string tempString = "";
            while (counter < strInput.Length)
            {
                tempString += strInput[counter];
                counter++;
                if (counter%length == 0 || counter == strInput.Length)
                {
                    stringsList.Add(tempString);
                    tempString = "";
                }
            }
            for (int i = 0; i < stringsList.Count; i++)
            {
                while (stringsList[i].Length < length)
                {
                    stringsList[i] += " ";
                }
            }
            for (int i = stringsList.Count-1; i>=0;i--)
            {
                for (int j = 0; j < length; j++)
                {
                    if (stringsList[i][j] == ' ')
                    {
                        int counterI = i;
                        bool hasFound = true;
                        while (stringsList[counterI][j] == ' ')
                        {
                            counterI--;
                            if (counterI == -1)
                            {
                                hasFound = false;
                                break;
                            }
                        }
                        
                        if (hasFound)
                        {
                            stringsList[i] = stringsList[i].Remove(j, 1).Insert(j, stringsList[counterI][j].ToString());
                            stringsList[counterI] = stringsList[counterI].Remove(j, 1).Insert(j, " ");
                        }
                    }
                }
            }
            Console.Write("<table>");
            foreach (String line in stringsList)
            {
                Console.Write("<tr>");
                foreach (char letter in line)
                {
                    Console.Write("<td>{0}</td>",System.Security.SecurityElement.Escape(letter.ToString()));
                }
                Console.Write("</tr>");
            }
            Console.Write("</table>");
        }
    }
}
