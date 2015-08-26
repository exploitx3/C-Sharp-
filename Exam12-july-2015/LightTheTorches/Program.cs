using System;


namespace LightTheTorches
{
    class Program
    {
        static void Main(string[] args)
        {
            int numRooms = int.Parse(Console.ReadLine());
            string strLine = Console.ReadLine();
            if(strLine.Length>numRooms)
            {
                return;
            }
            char[] rooms = new char[numRooms];
            
            for (int i = 0,j=0; i < numRooms; i++,j++)
            {
                rooms[i] = strLine[j];
                if(j == strLine.Length-1)
                {
                    j=-1;
                }
            }
           
           
            int state = numRooms / 2;
            string[] command = new string[11];
            
            int secondState = 0;
            while(command[0] != "END")
            {
                command = Console.ReadLine().Split(' ');
                if(command[0] == "END")
                {
                    break;
                }
                
                secondState = state;
              
                if(command[0] == "LEFT")
                {
                    state -= int.Parse(command[1])+1;
                    if(state<0)
                    {
                        state = 0;
                    }
                    if (state != secondState)
                    {
                        if (rooms[state] == 'D')
                        {
                            rooms[state] = 'L';
                        }
                        else if (rooms[state] == 'L')
                        {
                            rooms[state] = 'D';
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                if(command[0] == "RIGHT")
                {
                    state += int.Parse(command[1])+1;
                    if (state >= rooms.Length)
                    {
                        state = rooms.Length-1;
                    }
                    if (state != secondState)
                    {
                        if (rooms[state] == 'D')
                        {
                            rooms[state] = 'L';
                        }
                        else if (rooms[state] == 'L')
                        {
                            rooms[state] = 'D';
                        }
                    }else
                    {
                        continue;
                    }
                }
            }
            int darkCount = 0;
            for (int i = 0; i < rooms.Length; i++)
            {
                
                if(rooms[i] == 'D')
                {
                    darkCount++;
                }
            }
            Console.WriteLine(darkCount*(int)'D');
        }
    }
}
