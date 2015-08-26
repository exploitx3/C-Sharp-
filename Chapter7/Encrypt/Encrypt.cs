using System;


namespace Encrypt
{
    class Encrypt
    {
        static void Main()
        {
            string[] strArr = new string[100];
            
            int counter = 0;
            string start = null;
            do
            {
                start = Console.ReadLine();
            } while (start !="START" && start != "start");
            int i = -1;
            do
            {
                i++;
                strArr[i] = Console.ReadLine();
                
            } while (strArr[i]!="END" && strArr[i]!="end");
            for (int j = 0; j < strArr.Length; j++)
            {
                if(strArr[j] == "END" || strArr[j] == "end")
                {
                    strArr[j] =  null;
                }
                
            }
            string[] strArrResult = new string[i+1];

            char[] chArr;
            char[] chArrRes;
            for (int j = 0; j < strArr.Length; j++)
            {
                if(strArr[j] != null)
                {
                    chArr = strArr[j].ToCharArray();
                    chArrRes = strArr[j].ToCharArray();
                    for (int k = strArr[j].Length-1,n=0; k > -1; k--,n++)
                    {
                        chArr[k] = EncryptChar(chArr[k]);
                        chArrRes[n] = chArr[k];
                        
                    }
                    strArrResult[counter] = new string(chArrRes);                    
                        counter++;
                    
                    
                    
                }
            }
            
            int strCounter = 0;
            bool zero = true;
            int messege = 0;
            for (int l = 0; l < counter; l++)
            {
                
                if(strArrResult[l].Length != 0)
                {
                    zero = false;
                    messege++;
                }
                else
                {
                    
                }
            }
            if (zero)
            {
                Console.WriteLine("No messages sent.");
            }
            else
            {
                Console.WriteLine("Total number of messages: " + messege);
                for (int l = 0; l < counter; l++)
                {

                    if (strArrResult[l].Length != 0)
                    {
                        Console.WriteLine(strArrResult[l]);
                    }

                }
            }
            

            
        }
        static char EncryptChar(char ch)
        {
            bool amLarge = ch >= 65 && ch <= 77;
            bool nzLarge = ch >= 78 && ch <= 90;
            bool amSmall = ch >= 97 && ch <= 109;
            bool nzSmall = ch >= 110 && ch <= 122;
            if(amLarge)
            {
                return (char)(ch+13);
            }
            if(nzLarge)
            {
                return (char)(ch-13);
            }
            if (amSmall)
            {
                return (char)(ch + 13);
            }
            if (nzSmall)
            {
                return (char)(ch - 13);
            }
            switch(ch)
            {
                case ' ':
                    return '+';
                case ',':
                    return '%';
                case '.' :
                    return '&';
                case '?' :
                    return '#';
                case '!':
                    return '$';
                default:
                    return ch;
            }
            
        }
    }
}
