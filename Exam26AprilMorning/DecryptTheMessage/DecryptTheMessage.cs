using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecryptTheMessage
{
    class DecryptTheMessage
    {
        static char Decrypt(char oldCh)
    {
            switch(oldCh)
            {
                case '+':
                return ' ';
                case '%':
                return ',';
                
                case '&':
                return '.';
                case '#':
                return '?';
                case '$':
                return '!';
                default:
                
                    if (oldCh >= 'A' && oldCh <= 'M')
                    {
                        return (char)((int)oldCh + 13);
                    }
                    if (oldCh >= 'N' && oldCh <= 'Z')
                    {
                        return (char)((int)oldCh - 13);
                    }
                    if (oldCh >= 'a' && oldCh <= 'm')
                    {
                        return (char)((int)oldCh + 13);
                    }
                    if (oldCh >= 'n' && oldCh <= 'z')
                    {
                        return (char)((int)oldCh - 13);
                    }
                    return oldCh;
        
                


            }
        
    
    }
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            
            List<string> msgList = new List<string>();
            
            while(message.ToLower()!="start")
            {
                message = Console.ReadLine();
            }
            while(message.ToLower()!="end")
            {
                message = Console.ReadLine();
                if(message != "" && message.ToLower() != "end")
                {
                    msgList.Add(message);
            
                }
            }
            string[] msg =  msgList.ToArray();
            for (int i = 0; i < msgList.Count; i++)
			{
                char[] chArr = msg[i].ToCharArray();
                for (int j = 0,k=msgList[i].Length-1; j < msgList[i].Length; j++,k--)
			{
              
			   chArr[k]=Decrypt(msgList[i][j]);
			}
                msg[i] = new string(chArr);
            }
            if(msgList.Count != 0)
            {
                Console.WriteLine("Total number of messages: {0}",msgList.Count);
            }
            else
            {
                Console.WriteLine("No message received.");
            }
                for (int i = 0; i < msg.Length; i++)
			{
			 Console.WriteLine(msg[i]);
			}
        }
    }
}
