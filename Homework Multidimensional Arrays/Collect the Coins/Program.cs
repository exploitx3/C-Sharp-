
using System;

namespace Collect_the_Coins
{
	class Program
	{
		public static void Main(string[] args)
		{
			string[] strings = new string[4];
			for (int i = 0; i < 4; i++) {
				strings[i] = Console.ReadLine();
			}
			string commands = Console.ReadLine();
			int row = 0;
			int col = 0;
			int wallsHit = 0;
			int coins = 0;
			for (int i = 0; i < commands.Length; i++) {
				try{
				if(strings[row][col] == '$')
				{
					coins++;
				}
				}catch(Exception)
				{
					wallsHit++;
				}
				if(commands[i] == 'V')
				{
					if(row+1 < 4)
					{
						row++;
					}
								
				}
				if(commands[i] == '^')
				{
					if(row-1 >= 0)
					{
						row--;
					}
								
				}
				if(commands[i] == '>')
				{
					if(col+1 < strings[row].Length)
					{
						col++;
					}
									
				}
				if(commands[i] == '<')
				{
					if(col-1>=0)
					{
						col--;
					}
					
				}
			}
			Console.WriteLine("Coins collected: {0}",coins);
			Console.WriteLine("Walls hit: {0}",wallsHit);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}