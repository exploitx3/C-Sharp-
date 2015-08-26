using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBuilder
{
    class BitBuilder
    {
        static void Main(string[] args)
        {            
            long number = long.Parse(Console.ReadLine());
            string strNumber = Convert.ToString(number, 2).PadLeft(64, '0');
            string command = Console.ReadLine();      
            while (command != "quit")
            {
                int position = Math.Abs(int.Parse(command) - 63);
                command = Console.ReadLine();
                string  body = strNumber.Substring((position + 1), (63 - position));   
                switch(command)
                {
                    case "flip":
                        {
                            if (strNumber[position] == '1')
                            {
                                string temp = strNumber.Substring(0, position);
                                strNumber = temp + "0" + body;
                            }
                            else if (strNumber[position] == '0')
                            {
                                string temp = strNumber.Substring(0, position);
                                strNumber = temp + "1" + body;
                            }
                            break;
                        }
                    case "insert":
                        {
                            string temp = strNumber.Substring(1, position);
                            strNumber = temp + "1" + body;
                            break;
                        }
                    case "remove":
                        {
                            string temp = strNumber.Substring(0, position);
                            strNumber = "0" + temp + body;
                            break;
                        }
                    default:
                        break;
                }               
                command = Console.ReadLine();
            }      
            Console.WriteLine(Convert.ToInt64(strNumber, 2));         
        }
    }
}