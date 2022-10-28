using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Storage storage = new FileStorage();
			storage.Save("abc");
		}
	}
	/// <summary>
	/// 可以用來儲存資訊的類別
	/// </summary>
	public abstract class Storage
	{
		/// <summary>
		/// 將content 存檔,但,父類別其實不知道要怎麼存...
		/// </summary>
		/// <param name="content"></param>
		public void Save(string content)
		{
			if (string.IsNullOrEmpty(content))
			{
				return; // 如果沒資料就不存了
			}

			SaveInfo(content);
		}

		protected abstract void SaveInfo(string content);
	}
	/// <summary>
	/// 可以將資訊存放在database的類別
	/// /// </summary>
	public class DbStorage : Storage
	{
		protected override void SaveInfo(string content)
		{
			// 將 content 存放到db
		}
	}

	/// <summary>
	/// 可以將資訊存放在單一檔案的類別
	/// </summary>
	public class FileStorage : Storage
	{
		protected override void SaveInfo(string content)
		{
			// 將content 存放到實體檔案
		}
	}

}
