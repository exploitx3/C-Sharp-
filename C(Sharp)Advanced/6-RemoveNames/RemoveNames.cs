using System;


namespace _6_RemoveNames
{
    class RemoveNames
    {
        static void Main()
        {
            string[] names = Console.ReadLine().Split(' ');
            string[] remNames = Console.ReadLine().Split(' ');
            
            
            
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < remNames.Length; j++)
			    {
			 
                    if(names[i] == remNames[j])
                    {
                        names[i] = "";
                    }
		    	}
                
          
            }
            for (int i = 0; i < names.Length; i++)
            {
                if(names[i] != "")
                {
                    Console.Write(names[i] + " ");
                }
                
            }
            Console.WriteLine();

        }
    }
}
