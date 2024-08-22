namespace Alarm_Clock
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
			components = new System.ComponentModel.Container();
			timelabel = new Label();
			timer1 = new System.Windows.Forms.Timer(components);
			dateTimePicker1 = new DateTimePicker();
			button1 = new Button();
			settimelabel = new Label();
			button2 = new Button();
			SuspendLayout();
			// 
			// timelabel
			// 
			timelabel.BackColor = SystemColors.ButtonHighlight;
			timelabel.Font = new Font("맑은 고딕", 12F);
			timelabel.Location = new Point(12, 9);
			timelabel.Name = "timelabel";
			timelabel.Size = new Size(310, 32);
			timelabel.TabIndex = 0;
			timelabel.Text = "현재 시간 : 오전 00:00:00";
			timelabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// timer1
			// 
			timer1.Interval = 1000;
			timer1.Tick += timer1_Tick;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Font = new Font("맑은 고딕", 11F);
			dateTimePicker1.Format = DateTimePickerFormat.Time;
			dateTimePicker1.Location = new Point(12, 100);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.ShowUpDown = true;
			dateTimePicker1.Size = new Size(310, 27);
			dateTimePicker1.TabIndex = 1;
			// 
			// button1
			// 
			button1.BackColor = SystemColors.ButtonFace;
			button1.FlatStyle = FlatStyle.Popup;
			button1.Font = new Font("맑은 고딕", 12F);
			button1.Location = new Point(12, 169);
			button1.Name = "button1";
			button1.Size = new Size(310, 30);
			button1.TabIndex = 2;
			button1.Text = "Reset";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// settimelabel
			// 
			settimelabel.BackColor = SystemColors.ControlLight;
			settimelabel.Font = new Font("맑은 고딕", 12F);
			settimelabel.Location = new Point(12, 62);
			settimelabel.Margin = new Padding(3);
			settimelabel.Name = "settimelabel";
			settimelabel.Size = new Size(310, 32);
			settimelabel.TabIndex = 3;
			settimelabel.Text = "알림 미설정";
			settimelabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// button2
			// 
			button2.BackColor = SystemColors.ButtonFace;
			button2.FlatStyle = FlatStyle.Popup;
			button2.Font = new Font("맑은 고딕", 12F);
			button2.Location = new Point(12, 133);
			button2.Name = "button2";
			button2.Size = new Size(310, 30);
			button2.TabIndex = 4;
			button2.Text = "Set";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ScrollBar;
			ClientSize = new Size(334, 211);
			Controls.Add(button2);
			Controls.Add(settimelabel);
			Controls.Add(button1);
			Controls.Add(dateTimePicker1);
			Controls.Add(timelabel);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
		}

		#endregion

		private Label timelabel;
		private System.Windows.Forms.Timer timer1;
		private DateTimePicker dateTimePicker1;
		private Button button1;
		private Label settimelabel;
		private Button button2;
	}
}
