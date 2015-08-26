using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerology
{
    class Numerology
    {
        static int ConvertChar(char ch)
        {
            if(ch >= 'a' && ch <= 'z')
            {
                return ch - 96; 
            }else if(ch >= 'A' && ch <= 'Z')
            {
                return (ch - 64) * 2;
            }else if(ch>='0' && ch <= '9')
            {
                return (ch - 48);
            }else
            {
                return ch;
            }

        }
        static void Main(string[] args)
        {
            string[] strInput = Console.ReadLine().Split(' ');
            string[] dateStr = strInput[0].Split('.');
            strInput[0].Replace('.', '0');
            long sum = 1;
            for (int i = 0; i < dateStr.Length; i++)
            {
                sum *= int.Parse(dateStr[i]);
            }
            if(strInput[0][4] % 2 != 0)
            {
                sum = sum*sum;
            }
            for (int i = 0; i < strInput[1].Length; i++)
            {
                sum += ConvertChar(strInput[1][i]);
            }
            while(sum>13)
            {
                string temp = Convert.ToString(sum);
                int tempSum = 0;
                for (int i = 0; i < temp.Length; i++)
                {
                    tempSum += (temp[i] - '0');
                }
                sum = tempSum;
            }
            Console.WriteLine(sum);
        }
    }
}
