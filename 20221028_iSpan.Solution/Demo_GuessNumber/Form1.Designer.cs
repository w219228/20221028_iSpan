﻿namespace Demo_GuessNumber
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.newGameButton = new System.Windows.Forms.Button();
			this.guessTextBox = new System.Windows.Forms.TextBox();
			this.guessButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// newGameButton
			// 
			this.newGameButton.Location = new System.Drawing.Point(277, 29);
			this.newGameButton.Name = "newGameButton";
			this.newGameButton.Size = new System.Drawing.Size(75, 23);
			this.newGameButton.TabIndex = 0;
			this.newGameButton.Text = "New Game";
			this.newGameButton.UseVisualStyleBackColor = true;
			this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
			// 
			// guessTextBox
			// 
			this.guessTextBox.Location = new System.Drawing.Point(304, 126);
			this.guessTextBox.Name = "guessTextBox";
			this.guessTextBox.Size = new System.Drawing.Size(100, 22);
			this.guessTextBox.TabIndex = 1;
			// 
			// guessButton
			// 
			this.guessButton.Location = new System.Drawing.Point(422, 124);
			this.guessButton.Name = "guessButton";
			this.guessButton.Size = new System.Drawing.Size(75, 23);
			this.guessButton.TabIndex = 2;
			this.guessButton.Text = "猜猜看";
			this.guessButton.UseVisualStyleBackColor = true;
			this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(293, 184);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.guessButton);
			this.Controls.Add(this.guessTextBox);
			this.Controls.Add(this.newGameButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button newGameButton;
		private System.Windows.Forms.TextBox guessTextBox;
		private System.Windows.Forms.Button guessButton;
		private System.Windows.Forms.Label label1;
	}
}

