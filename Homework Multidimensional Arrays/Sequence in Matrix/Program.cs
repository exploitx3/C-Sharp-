
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sequence_in_Matrix
{
	class Program
	{
		public static void Main(string[] args)
		{
			int rows = int.Parse(Console.ReadLine());
			int cols = int.Parse(Console.ReadLine());
			string[,] strArr = new string[rows,cols];
			
			for (int i = 0; i < rows; i++) {
				for (int j = 0; j < cols; j++) {
					strArr[i,j] = Console.ReadLine();
				}
			}
			int longestSequenceLength = 0;
			int longestSequenceRow = 0;
			int longestSequenceCol = 0;
			int sequenceLength = 0;
			for (int i = 0; i < rows; i++) {
				for (int j = 0; j < cols; j++) {
					 sequenceLength = 0;
					for (int k = i+1; k < rows; k++) {
						for (int l = j+1; l < cols; l++) {
							if(strArr[i,j] == strArr[k,l])
							{
								sequenceLength++;
							}
						}
					}
					if(sequenceLength > longestSequenceLength)
					{
						longestSequenceLength = sequenceLength;
						longestSequenceRow = i;
						longestSequenceCol = j;
					}
					sequenceLength = 0;
					for (int k = j+1; k < cols; k++) {
						if(strArr[i,j] == strArr[i,k])
						{
							sequenceLength++;
						}
					}
					if(sequenceLength > longestSequenceLength)
					{
						longestSequenceLength = sequenceLength;
						longestSequenceRow = i;
						longestSequenceCol = j;
					}
					sequenceLength = 0;
					for (int k = i+1; k < rows; k++) {
						if(strArr[i,j] == strArr[k,j])
						{
							sequenceLength++;
						}
					}
					if(sequenceLength > longestSequenceLength)
					{
						longestSequenceLength = sequenceLength;
						longestSequenceRow = i;
						longestSequenceCol = j;
					}
				}
			}
			for (int i = 0; i <= longestSequenceLength; i++) {
				Console.Write(strArr[longestSequenceRow,longestSequenceCol]);
				if(i!=longestSequenceLength)
				{
					Console.Write(", ");
				}
			}
			Console.WriteLine();
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}