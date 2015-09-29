using System.Collections.Generic;
using System.Linq;
using System;

namespace Phonebook
{
	class Program
	{
		public static void Main(string[] args)
		{
			Dictionary<string,List<string>> phoneBook = new Dictionary<string, List<string>>();
			List<string> list = new List<string>();
			string[] input = Console.ReadLine().Split('-');
			while(input[0] != "search")
			{
				if(phoneBook.ContainsKey(input[0]))
				   {
					phoneBook[input[0]].Add(", " + input[1]);
				   }
				else
				{
				phoneBook.Add(input[0],new List<string>{input[1]});
				}
				input = Console.ReadLine().Split('-');
			}
			string searchKey = Console.ReadLine();
			while(searchKey != "")
			{
				if(phoneBook.ContainsKey(searchKey))
				{
					list.Add(searchKey + " -> ");
					list.AddRange(phoneBook[searchKey]);
					list.Add("\n");
				}
				else
				{
					list.Add("Contact " + searchKey + " does not exist.\n");
				}
				searchKey = Console.ReadLine();
			}

			for (int i = 0; i < list.Count; i++) {
				Console.Write(list[i]);
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}