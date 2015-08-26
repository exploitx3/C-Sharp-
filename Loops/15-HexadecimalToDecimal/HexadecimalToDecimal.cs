using System;

namespace _15_HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {
        static int Hex(char h)
        {
            switch(h)
            {
                case '0':
                    return 0;
                     
                case '1':
                    return 1;
                     
                case '2':
                    return 2;
                     
                case '3':
                    return 3;
                     
                case '4':
                    return 4;
                     
                case '5':
                    return 5;
                     
                case '6':
                    return 6;
                     
                case '7':
                    return 7;
                     
                case '8':
                    return 8;
                     
                case '9':
                    return 9;
                     
                case 'A':
                    return 10;
                     
                case 'B':
                    return 11;
                     
                case 'C':
                    return 12;
                     
                case 'D':
                    return 13;
                     
                case 'E':
                    return 14;
                     
                case 'F':
                    return 15;
                     
                default:
                    return 0;
            }
        }
        static void Main()
        {
            string strNum = Console.ReadLine();
            char[] charNum = strNum.ToCharArray();
            long hexNumber = 0;
            for (int i = 0; i < charNum.Length; i++)
            {
                hexNumber += Hex(charNum[charNum.Length - 1 - i]) * (long)Math.Pow(16, i);
            }
            Console.WriteLine(hexNumber);
        }
    }
}
