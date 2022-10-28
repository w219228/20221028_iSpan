using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var member = new Member { IsSuccess = false, Hint = "xxx" };
		}
	}
	class Member {
		
		public bool IsSuccess { get; set; }
		public string Hint { get; set; }
	}
}
