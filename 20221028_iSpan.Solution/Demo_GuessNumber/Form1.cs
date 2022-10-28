using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_GuessNumber
{
	public partial class Form1 : Form
	{
		private GuessNumber game;

		public Form1()
		{
			InitializeComponent();
		}

		private void newGameButton_Click(object sender, EventArgs e)
		{
			game = new GuessNumber();
			game.NewGame();
		}

		private void guessButton_Click(object sender, EventArgs e)
		{
			int guessNumber = GetGuessNumber();//取得這次使用者猜測的數字
			GuessResult result = game.Guess(guessNumber);

			if (result.IsSuccess == true)
			{
				MessageBox.Show("猜對了!!!");
			}
			else
			{
				label1.Text = $"介於 {result.Hint}";
			}
		}
	}
	public class GuessResult
	{
		public bool IsSuccess { get; set; }
		public string Hint { get; set; }
	}
	/// <summary>
	/// 猜數字遊戲
	/// </summary>
	public class GuessNumber
	{
		public GuessResult Guess(int number)
		{

		}

		/// <summary>
		/// 開始一個新的猜數字遊戲
		/// </summary>
		public void NewGame() { 
		
		}
	}
}
