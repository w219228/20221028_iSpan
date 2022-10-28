using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// int[] items = { 3, 99, 2, 1 };
			// string[] items = { "Z", "C", "A", "R"};

			//DateTime[] items = {new DateTime(1970,1,1),
			//new DateTime(1960,1,1),
			//new DateTime(1980,1,1),
			//};

			Member[] items = { 
				new Member{Name="A1", Height=170, DateOfBirth=new DateTime(1980,1,1) },
				new Member{Name="A2", Height=160, DateOfBirth=new DateTime(1970,1,1) },
				new Member{Name="A3", Height=180, DateOfBirth=new DateTime(1960,1,1) },

			};

			// Array.Sort(items);
			
			//IComparer<Member> comparer = new CompareByNameDESC();
			// comparer = new CompareByNameASC();

			Array.Sort(items, Member.按姓名遞增排序);

			foreach (var item in items)
			{
				Console.WriteLine(item);
			}
		}
	}
	public class CompareByNameASC : IComparer<Member>
	{
		public int Compare(Member x, Member y)
		{
			return x.Name.CompareTo(y.Name);
		}
	}
	public class CompareByNameDESC : IComparer<Member>
	{
		public int Compare(Member x, Member y)
		{
			return y.Name.CompareTo(x.Name);
		}
	}

	public class Member:IComparable<Member>
	{
		public static IComparer<Member> 按姓名遞減排序
		{
			get
			{
				return new CompareByNameDESC();
			}
		}
		public static IComparer<Member> 按姓名遞增排序
		{
			get
			{
				return new CompareByNameASC();
			}
		}
		public int Height { get; set; }
		public string Name { get; set; }
		public DateTime DateOfBirth { get; set; }

		public int CompareTo(Member other)
		{
			Member x = this;
			Member y = other;

			return y.DateOfBirth.CompareTo(x.DateOfBirth);

			//if (x.Height > y.Height)
			//	return 1000;
			//else if (x.Height == y.Height)
			//	return 0;
			//else
			//	return -999;
		}

		public override string ToString()
		{
			return $"Name={Name}, Height={Height}, Birthday={DateOfBirth:yyyy/MM/dd}";
		}
	}
}
