using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Member[] items = {
				new Member{Name="A1", Height=170, DateOfBirth=new DateTime(1980,1,1) },
				new Member{Name="A2", Height=160, DateOfBirth=new DateTime(1970,1,1) },
				new Member{Name="A3", Height=180, DateOfBirth=new DateTime(1960,1,1) },

			};


			
			foreach (var item in items.Where(m=>m.Height>=170).OrderBy(m=>m.DateOfBirth)    )
			{
				Console.WriteLine(item);
			}
		}
	}
	public class Member
	{
		public int Height { get; set; }
		public string Name { get; set; }
		public DateTime DateOfBirth { get; set; }
		public override string ToString()
		{
			return $"Name={Name}, Height={Height}, Birthday={DateOfBirth:yyyy/MM/dd}";
		}
	}
}
