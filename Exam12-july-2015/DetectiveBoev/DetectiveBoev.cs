using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectiveBoev
{
    class DetectiveBoev
    {
        static void Main()
        {
            string secretWord = Console.ReadLine();
            int secretCode = 0;
            
            for (int i = 0; i < secretWord.Length; i++)
            {
                secretCode += (int)secretWord[i];
            }
            string secret = Convert.ToString(secretCode);
            secretCode = 0;
            for (int i = 0; i < secret.Length; i++)
            {
                secretCode += (int)(secret[i]-'0');
            }
            if(secretCode>9)
            {
                secret = Convert.ToString(secretCode);
                secretCode = 0;
                for (int i = 0; i < secret.Length; i++)
                {
                    secretCode += (int)(secret[i] - '0');
                }
            }
            string message = Console.ReadLine();
            char[] decryptedMessage = new char[message.Length];
            for (int i = 0,j=message.Length-1; i < message.Length; i++,j--)
            {
                if(message[i]%secretCode==0)
                {
                    decryptedMessage[j] = (char)((int)message[i] + secretCode);
                }
                 if(message[i]%secretCode!=0)
                {
                    decryptedMessage[j] = (char)((int)message[i] - secretCode);
                }
            }
            for (int i = 0; i < decryptedMessage.Length; i++)
            {
                Console.Write(decryptedMessage[i]);
            }
            Console.WriteLine();
        }
    }
}
