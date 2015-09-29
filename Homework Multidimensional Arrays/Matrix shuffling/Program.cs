
using System;
using System.Collections.Generic;

namespace Matrix_shuffling
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			List<string> strList = new List<string>();
			int rows = int.Parse(Console.ReadLine());
			int cols = int.Parse(Console.ReadLine());
			string[,] strArr = new string[rows,cols];
			for (int i = 0; i < rows; i++) {
				for (int j = 0; j < cols; j++) {
					strArr[i,j] = Console.ReadLine();
				}
			}
			string[] command = Console.ReadLine().Split(' ');
			bool incorrect;
			while(command[0] != "END")
			{
				incorrect = true;
				if(command[0] == "swap" && command.Length == 5)
				{
					int firstRow = int.Parse(command[1]);
					int firstCol = int.Parse(command[2]);
					int secondRow = int.Parse(command[3]);
					int secondCol = int.Parse(command[4]);
					if((firstRow < rows && firstCol < cols) &&
					   (secondRow < rows && secondCol < cols))
					   {
						string temp = strArr[firstRow,firstCol];
						strArr[firstRow,firstCol] = strArr[secondRow,secondCol];
						strArr[secondRow,secondCol] = temp;
						incorrect = false;
						
					   }
					else
					{
						incorrect = true;
					}
					
				}
				if(!incorrect)
					{
						for (int i = 0; i < rows; i++) {
						strList.Add("\n");
							for (int j = 0; j < cols; j++) {
								strList.Add(strArr[i,j] + " ");
							}
							strList.Add("\n");
						}
						
					}
					else
					{
						strList.Add("\nInvalid Input!\n\n");
					}
				command = Console.ReadLine().Split(' ');
			}
			for (int i = 0; i < strList.Count; i++) {
				Console.Write(strList[i]);
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}