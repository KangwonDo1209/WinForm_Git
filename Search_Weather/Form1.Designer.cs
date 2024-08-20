namespace Search_Weather
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBox1 = new TextBox();
			button1 = new Button();
			richTextBox1 = new RichTextBox();
			textBox2 = new TextBox();
			button2 = new Button();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Font = new Font("맑은 고딕", 12F);
			textBox1.Location = new Point(276, 12);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(210, 29);
			textBox1.TabIndex = 0;
			// 
			// button1
			// 
			button1.Location = new Point(492, 12);
			button1.Name = "button1";
			button1.Size = new Size(80, 29);
			button1.TabIndex = 1;
			button1.Text = "Click";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// richTextBox1
			// 
			richTextBox1.Location = new Point(12, 47);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.ReadOnly = true;
			richTextBox1.Size = new Size(560, 275);
			richTextBox1.TabIndex = 2;
			richTextBox1.Text = "";
			richTextBox1.TextChanged += richTextBox1_TextChanged;
			// 
			// textBox2
			// 
			textBox2.BackColor = SystemColors.Info;
			textBox2.Font = new Font("맑은 고딕", 12F);
			textBox2.Location = new Point(12, 12);
			textBox2.Name = "textBox2";
			textBox2.ReadOnly = true;
			textBox2.Size = new Size(258, 29);
			textBox2.TabIndex = 3;
			textBox2.Text = "지역";
			textBox2.TextAlign = HorizontalAlignment.Center;
			// 
			// button2
			// 
			button2.Location = new Point(12, 328);
			button2.Name = "button2";
			button2.Size = new Size(560, 29);
			button2.TabIndex = 4;
			button2.Text = "https://www.code.go.kr/stdcode/regCodeL.do";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(584, 361);
			Controls.Add(button2);
			Controls.Add(textBox2);
			Controls.Add(richTextBox1);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private Button button1;
		private RichTextBox richTextBox1;
		private TextBox textBox2;
		private Button button2;
	}
}
