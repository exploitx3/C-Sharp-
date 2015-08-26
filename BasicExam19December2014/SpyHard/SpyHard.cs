using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpyHard
{
    class SpyHard
    {
        const string Digits = "0123456789A";
        static string Convert(int key,int number)
        {
            string strResult = "";
            
            while(number != 0)
            {
                int remainder = (int)(number % key);
                strResult += remainder;
                number /= key;
            }
            char[] chArr = strResult.ToCharArray();
            Array.Reverse(chArr);
            strResult = new string(chArr);
            return strResult;
        }
        static int Letter(char ch)
        {
            if(ch >= 'A' && ch <= 'Z')
            {
                return ch - 64;
            }else if(ch >= 'a' && ch <= 'z')
            {
                return ch - 96;
            }
            else
            {
                return (int)ch;
            }
        }
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            string message = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < message.Length; i++)
            {
                sum += Letter(message[i]);
            }
            Console.WriteLine("{0}{1}{2}",key,message.Length,Convert(key,sum));

        }
    }
}
