
using System;

namespace Fill_the_Matrix
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int n = int.Parse(Console.ReadLine());
			int[,] patternAarray = new int[7,7];
			int counter = 1;
			int row = 0;
			int col = 0;
			while(counter<=n*n)
			{
				patternAarray[row,col] = counter;				
				row++;
				counter++;
				if(row==n)
				{
					row=0;
					col++;
				}
			}
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write("{0,5}",patternAarray[i,j]);
				}
				Console.WriteLine();
			}
			counter = 1;
			row = 0;
			col = 0;
			bool rowBool = false;
			while(counter<=n*n)
			{
				patternAarray[row,col] = counter;
				counter++;
				if(!rowBool)
				{
					row++;
				}
				else
				{
					row--;
				}
				if(rowBool == false)
				{
					if(row == n)
					{
					col++;
					rowBool = true;
					row--;
					}
				}
				else
				{	
					if(row == -1)
					{
					col++;
					rowBool = false;
					row = 0;
					
					}
				}
				
				
				
			}
			Console.WriteLine();
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write("{0,5}",patternAarray[i,j]);
				}
				Console.WriteLine();
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}