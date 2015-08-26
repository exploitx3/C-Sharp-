using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptedMatrix
{
    class EncryptedMatrix
    {
        static void Main(string[] args)
        {
            string msgInput = Console.ReadLine();
            char directionCharacter = char.Parse(Console.ReadLine());
            string msgNumber = null;
            
            for (int i = 0; i < msgInput.Length; i++)
            {
                msgNumber += ((int)msgInput[i]) % 10;
            }

            StringBuilder encryptedString = new StringBuilder();
            encryptedString.Append('a', 500);
            for (int i = 0,counter = 0; i < msgNumber.Length;counter++, i++)
            {
                if((int)(msgNumber[i]) % 2 == 0)
                {
                    string  temp = Convert.ToString((int)(msgNumber[i] - '0') * (int)(msgNumber[i] - '0'));                  
                    encryptedString.Remove(counter, 1);
                    encryptedString.Insert(counter,temp);
                    if (int.Parse(temp) > 9)
                    {
                        counter++;
                    }
                }
                else
                {
                    int leftNeightbour = 0;
                    int rightNeighbour = 0;
                    if(i>0)
                    {
                        leftNeightbour = (int)(msgNumber[i - 1] - '0');
                    }
                    if(i<msgNumber.Length-1)
                    {
                        rightNeighbour=(int)(msgNumber[i + 1] - '0');
                    }
                    string temp = Convert.ToString(((int)msgNumber[i]-'0')+leftNeightbour + rightNeighbour);
                    encryptedString.Remove(counter, 1);
                    encryptedString.Insert(counter, temp);
                    if(int.Parse(temp)>9)
                    {
                        counter++;
                    }
                }           
            }
            int index = 0;
            for (int i = 0; i < encryptedString.Length; i++)
            {
                if(encryptedString[i] == 'a')
                {
                    index = i;
                    break;
                }
            }
            encryptedString.Remove(index, encryptedString.Length - index);
            
            if(directionCharacter == '\\')
            {
                for (int i = 0; i < index ;i++)
                {
                    for (int j = 0; j < index; j++)
                    {
                        if(i==j)
                        {
                            Console.Write(encryptedString[i] + " ");
                        }
                        else
                        {
                            Console.Write(0+" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            
            if(directionCharacter == '/')
            {
                char[] revChar = encryptedString.ToString().ToCharArray();
                Array.Reverse(revChar);
                string temp = new string(revChar);
                encryptedString.Clear();
                encryptedString.Append(temp);
                for (int i = 0; i < index; i++)
                {
                    for (int j = 0; j < index; j++)
                    {
                        
                        if(i+j == index-1)
                        {
                            Console.Write(encryptedString[i]+ " ");
                        }
                        else
                        {
                            Console.Write(0+" ");
                        }
                   
                
                    }
                    Console.WriteLine();
                }
            }
            
        }
    }
}
