using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DoSomething(new Student { Email="student@gmail.com"});
			DoSomething(new Member { Email="member@gmail.com"});
		}

		static void DoSomething(IB obj)
		{
			Console.WriteLine(obj.Email);
			Console.WriteLine(obj.Add(1,2));
		}
	}
	class A {
		public string Name; // field, 欄位

		private string _Email;
		public string Email
		{
			get { return _Email; }
			set { _Email = value; }
		}
		public int Height { get; set; } // 屬性的簡短寫法

		// 方法,要有大括號
		public int Add(int num1, int num2)
		{
			return num1 + num2;
		}
	}
	
	interface IB { 
		// 介面裡,不能寫field

		//只能寫這個語法,不能寫public, private
		string Email { get; set; }

		/// <summary>
		/// 只能這樣宣告,不能有大括號,必需接分號
		/// </summary>
		/// <param name="num1"></param>
		/// <param name="num2"></param>
		/// <returns></returns>
		int Add(int num1, int num2);

	}
	class Student : IB
	{
		public string Email {
			get;set;
		}

		public int Add(int num1, int num2)
		{
			return num1 + num2 + 100;
		}
	}

	class Member : IB
	{
		public string Email { get; set; }

		public int Add(int num1, int num2)
		{
			return num1 + num2;
		}

	}
}
