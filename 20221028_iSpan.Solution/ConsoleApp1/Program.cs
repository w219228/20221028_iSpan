using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var random = new Random(12345);

			int number = random.Next(1, 100);
			Console.WriteLine(number);

			number = random.Next(1, 100);
			Console.WriteLine(number);
			
			number = random.Next(1, 100);
			Console.WriteLine(number);
		}
	}
}
