using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMatcher
{
    class ArrayMatcher
    {
        static void Main(string[] args)
        {
            string[] inputStr = Console.ReadLine().Split('\\');            
            string strResult = null;
            if(inputStr[2] == "join")
            {
               for (int i = 0; i < inputStr[0].Length; i++)
               {
			        if(inputStr[1].Contains(inputStr[0][i]))
                    {
                        strResult += inputStr[0][i];
                    }
               }
            }
            else if (inputStr[2] == "right exclude")
            {
                for (int i = 0; i < inputStr[0].Length; i++)
                {
                    if (!(inputStr[1].Contains(inputStr[0][i])))
                    {
                        strResult += inputStr[0][i];
                    }
                }
            }
            else if (inputStr[2] == "left exclude")
            {
                for (int i = 0; i < inputStr[1].Length; i++)
                {
                    if (!(inputStr[0].Contains(inputStr[1][i])))
                    {
                        strResult += inputStr[1][i];
                    }
                }
            }


            char[] chArr = strResult.ToCharArray();
            Array.Sort(chArr);
            strResult = new string(chArr);
            Console.WriteLine(strResult);
                
            }
        }
    }

