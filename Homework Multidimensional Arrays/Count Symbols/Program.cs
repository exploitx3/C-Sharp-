
using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Symbols
{
	class Program
	{
		public static void Main(string[] args)
		{
			string text = Console.ReadLine();
			Dictionary<char,int> letters = new Dictionary<char, int>();
			for (int i = 0; i < text.Length; i++) {
				int letterCounter = 0;
				for (int j = 0; j < text.Length; j++) {
					if(text[i] == text[j])
					{
						letterCounter++;
					}
				}
				if(!letters.ContainsKey(text[i]))
				   {
					letters.Add(text[i],letterCounter);
				   }
			}
			List<char> list = letters.Keys.ToList();
			list.Sort();
			foreach(var key in list)
			{
				Console.WriteLine("{0}: {1} time/s",key,letters[key]);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}