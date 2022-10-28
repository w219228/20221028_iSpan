using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		private GuessNumber game;

		public Form1()
		{
			InitializeComponent();

			game = new GuessNumber();
			resultLabel.Text = String.Empty;
		}

		private void newGameButton_Click(object sender, EventArgs e)
		{
			game.NewGame();
			resultLabel.Text = game.Hint;
		}

		private void guessButton_Click(object sender, EventArgs e)
		{
			int? guessNumber = GetGuessNumber();
			if (guessNumber.HasValue == false)
			{
				MessageBox.Show("請輸入整數再試一次");
				return;
			}
			

			GuessResult result = game.Guess(guessNumber.Value);
			if(result.IsSuccess == true)
			{
				MessageBox.Show("您答對了");
			}
			else
			{
				MessageBox.Show("您答錯了");
				resultLabel.Text = result.Hint;
			}
			
		}

		/// <summary>
		/// 取得使用者輸入的值
		/// </summary>
		/// <returns></returns>
		private int? GetGuessNumber()
		{
			TextBox txt = this.guessTextBox;
			string input = txt.Text;
			if (string.IsNullOrEmpty(input)) return null;

			bool isInt = int.TryParse(input, out int number);
			return isInt ? number : (int?)null;
		}
	}

	public class GuessNumber
	{
		const int minValue = 1;
		const int maxValue = 99;

		private int answer; // 這次遊戲的答案
		private int min= minValue, max= minValue; // 目前的數值範圍

		/// <summary>
		/// 新遊戲, 重新生出一個亂數[1,99]
		/// </summary>
		public void NewGame() {
			int seed = Guid.NewGuid().GetHashCode();
			var random = new Random(seed);
			answer = random.Next(1, 100);
			min = minValue;
			max = maxValue;
		}

		/// <summary>
		/// 猜看看,並回傳猜測結果
		/// </summary>
		/// <param name="guessNumber"></param>
		/// <returns></returns>
		public GuessResult Guess(int guessNumber) { 
			if(this.answer == guessNumber)
			{
				// 答對了
				// return new GuessResult { IsSuccess=true, Hint=string.Empty};
				return GuessResult.Success();
			}

			// 答錯了
			// 更新範圍 1~99,answer = 50, 猜62 => 更新範圍 1~62
			
			//1. 如果猜的在範圍內,就更新min,max
			if(guessNumber >=min && guessNumber <= max)
			{
				// 2.變更範圍
				if (guessNumber < answer)
				{
					min = guessNumber;
				}
				else
				{
					max = guessNumber;
				}
			}

			// 傳回答錯的資訊
			return GuessResult.Failed(this.Hint);
			
		}

		public string Hint
		{
			get
			{
				return $"{min} ~ {max}, answer = {answer}";
			}
		}
	}

	public class GuessResult {
		public static GuessResult Success()
		{
			return new GuessResult { IsSuccess = true, Hint = String.Empty };
		}
		public static GuessResult Failed(string errMessage)
		{
			return new GuessResult { IsSuccess = false, Hint = errMessage };
		}
		
		public bool IsSuccess { get; set; }
		/// <summary>
		/// 為何有了 IsSuccess屬性, 還要加寫 IsFailed 屬性?
		/// </summary>
		//public bool IsFailed { 
		//	get {
		//		return !IsSuccess;
		//	} 
		//}
		public bool IsFailed => !IsSuccess;

		public string Hint { get; set; }
	}
}
