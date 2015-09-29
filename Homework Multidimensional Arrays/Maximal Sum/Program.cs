
using System;



namespace Maximal_Sum
{
	class Program
	{
		public static void Main(string[] args)
		{
			string[] size =  Console.ReadLine().Split(' ');
			int rows = int.Parse(size[0]);
			int cols = int.Parse(size[1]);
			int[,] intArr = new int[rows,cols];
			for (int i = 0; i < rows; i++) {
				string[] strRow = Console.ReadLine().Split(' ');
				for (int j = 0; j < cols; j++) {
					intArr[i,j] = int.Parse(strRow[j]);
				}
			}
			int[,] secondArr = new int[3,3];
			int row = 0;
			int col = 0;
			int sum = 0;
			for (int i = rows/2-1; i <= rows/2+1; i++) {
				for (int j = cols/2-1; j <= cols/2+1; j++) {
					secondArr[row,col] = intArr[i,j];
					col++;
					sum+= intArr[i,j];
				}
				row++;
				col=0;
			}
			Console.WriteLine("Sum = {0}",sum);
			for (int i = 0; i < 3; i++) {
				for (int j = 0; j < 3; j++) {
					Console.Write("{0,-4}",secondArr[i,j]);
				}
				Console.WriteLine();
			}
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}