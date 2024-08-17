namespace Basic_Calculator
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
			display = new Label();
			ButtonLayout = new TableLayoutPanel();
			ButtonPoint = new Button();
			ButtonZero = new Button();
			ButtonSeven = new Button();
			ButtonEight = new Button();
			ButtonNine = new Button();
			ButtonDivide = new Button();
			ButtonFour = new Button();
			ButtonFive = new Button();
			ButtonSix = new Button();
			ButtonMultiply = new Button();
			ButtonOne = new Button();
			ButtonTwo = new Button();
			ButtonThree = new Button();
			ButtonSubtract = new Button();
			ButtonAllClear = new Button();
			ButtonAdd = new Button();
			ButtonResult = new Button();
			ButtonLayout.SuspendLayout();
			SuspendLayout();
			// 
			// display
			// 
			display.Dock = DockStyle.Top;
			display.Font = new Font("굴림", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
			display.Location = new Point(0, 0);
			display.Name = "display";
			display.Size = new Size(334, 40);
			display.TabIndex = 0;
			display.Text = "0";
			display.TextAlign = ContentAlignment.MiddleRight;
			// 
			// ButtonLayout
			// 
			ButtonLayout.ColumnCount = 4;
			ButtonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			ButtonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			ButtonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			ButtonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			ButtonLayout.Controls.Add(ButtonPoint, 0, 3);
			ButtonLayout.Controls.Add(ButtonZero, 0, 3);
			ButtonLayout.Controls.Add(ButtonSeven, 0, 0);
			ButtonLayout.Controls.Add(ButtonEight, 1, 0);
			ButtonLayout.Controls.Add(ButtonNine, 2, 0);
			ButtonLayout.Controls.Add(ButtonDivide, 3, 0);
			ButtonLayout.Controls.Add(ButtonFour, 0, 1);
			ButtonLayout.Controls.Add(ButtonFive, 1, 1);
			ButtonLayout.Controls.Add(ButtonSix, 2, 1);
			ButtonLayout.Controls.Add(ButtonMultiply, 3, 1);
			ButtonLayout.Controls.Add(ButtonOne, 0, 2);
			ButtonLayout.Controls.Add(ButtonTwo, 1, 2);
			ButtonLayout.Controls.Add(ButtonThree, 2, 2);
			ButtonLayout.Controls.Add(ButtonSubtract, 3, 2);
			ButtonLayout.Controls.Add(ButtonAllClear, 0, 3);
			ButtonLayout.Controls.Add(ButtonAdd, 3, 3);
			ButtonLayout.Location = new Point(0, 43);
			ButtonLayout.Name = "ButtonLayout";
			ButtonLayout.RowCount = 4;
			ButtonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			ButtonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			ButtonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			ButtonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			ButtonLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			ButtonLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			ButtonLayout.Size = new Size(334, 350);
			ButtonLayout.TabIndex = 1;
			// 
			// ButtonPoint
			// 
			ButtonPoint.Font = new Font("굴림", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
			ButtonPoint.Location = new Point(169, 264);
			ButtonPoint.Name = "ButtonPoint";
			ButtonPoint.Size = new Size(77, 83);
			ButtonPoint.TabIndex = 15;
			ButtonPoint.Text = ".";
			ButtonPoint.UseVisualStyleBackColor = true;
			ButtonPoint.Click += ButtonPoint_Click;
			// 
			// ButtonZero
			// 
			ButtonZero.Font = new Font("굴림", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
			ButtonZero.Location = new Point(86, 264);
			ButtonZero.Name = "ButtonZero";
			ButtonZero.Size = new Size(77, 83);
			ButtonZero.TabIndex = 14;
			ButtonZero.Text = "0";
			ButtonZero.UseVisualStyleBackColor = true;
			ButtonZero.Click += ButtonZero_Click;
			// 
			// ButtonSeven
			// 
			ButtonSeven.Font = new Font("굴림", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
			ButtonSeven.Location = new Point(3, 3);
			ButtonSeven.Name = "ButtonSeven";
			ButtonSeven.Size = new Size(77, 81);
			ButtonSeven.TabIndex = 1;
			ButtonSeven.Text = "7";
			ButtonSeven.UseVisualStyleBackColor = true;
			ButtonSeven.Click += ButtonSeven_Click;
			// 
			// ButtonEight
			// 
			ButtonEight.Font = new Font("굴림", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
			ButtonEight.Location = new Point(86, 3);
			ButtonEight.Name = "ButtonEight";
			ButtonEight.Size = new Size(77, 81);
			ButtonEight.TabIndex = 2;
			ButtonEight.Text = "8";
			ButtonEight.UseVisualStyleBackColor = true;
			ButtonEight.Click += ButtonEight_Click;
			// 
			// ButtonNine
			// 
			ButtonNine.Font = new Font("굴림", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
			ButtonNine.Location = new Point(169, 3);
			ButtonNine.Name = "ButtonNine";
			ButtonNine.Size = new Size(77, 81);
			ButtonNine.TabIndex = 3;
			ButtonNine.Text = "9";
			ButtonNine.UseVisualStyleBackColor = true;
			ButtonNine.Click += ButtonNine_Click;
			// 
			// ButtonDivide
			// 
			ButtonDivide.Font = new Font("굴림", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
			ButtonDivide.Location = new Point(252, 3);
			ButtonDivide.Name = "ButtonDivide";
			ButtonDivide.Size = new Size(79, 81);
			ButtonDivide.TabIndex = 4;
			ButtonDivide.Text = "÷";
			ButtonDivide.UseVisualStyleBackColor = true;
			ButtonDivide.Click += ButtonDivide_Click;
			// 
			// ButtonFour
			// 
			ButtonFour.Font = new Font("굴림", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
			ButtonFour.Location = new Point(3, 90);
			ButtonFour.Name = "ButtonFour";
			ButtonFour.Size = new Size(77, 81);
			ButtonFour.TabIndex = 5;
			ButtonFour.Text = "4";
			ButtonFour.UseVisualStyleBackColor = true;
			ButtonFour.Click += ButtonFour_Click;
			// 
			// ButtonFive
			// 
			ButtonFive.Font = new Font("굴림", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
			ButtonFive.Location = new Point(86, 90);
			ButtonFive.Name = "ButtonFive";
			ButtonFive.Size = new Size(77, 81);
			ButtonFive.TabIndex = 6;
			ButtonFive.Text = "5";
			ButtonFive.UseVisualStyleBackColor = true;
			ButtonFive.Click += ButtonFive_Click;
			// 
			// ButtonSix
			// 
			ButtonSix.Font = new Font("굴림", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
			ButtonSix.Location = new Point(169, 90);
			ButtonSix.Name = "ButtonSix";
			ButtonSix.Size = new Size(77, 81);
			ButtonSix.TabIndex = 7;
			ButtonSix.Text = "6";
			ButtonSix.UseVisualStyleBackColor = true;
			ButtonSix.Click += ButtonSix_Click;
			// 
			// ButtonMultiply
			// 
			ButtonMultiply.Font = new Font("굴림", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
			ButtonMultiply.Location = new Point(252, 90);
			ButtonMultiply.Name = "ButtonMultiply";
			ButtonMultiply.Size = new Size(79, 81);
			ButtonMultiply.TabIndex = 8;
			ButtonMultiply.Text = "×";
			ButtonMultiply.UseVisualStyleBackColor = true;
			ButtonMultiply.Click += ButtonMultiply_Click;
			// 
			// ButtonOne
			// 
			ButtonOne.Font = new Font("굴림", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
			ButtonOne.Location = new Point(3, 177);
			ButtonOne.Name = "ButtonOne";
			ButtonOne.Size = new Size(77, 81);
			ButtonOne.TabIndex = 9;
			ButtonOne.Text = "1";
			ButtonOne.UseVisualStyleBackColor = true;
			ButtonOne.Click += ButtonOne_Click;
			// 
			// ButtonTwo
			// 
			ButtonTwo.Font = new Font("굴림", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
			ButtonTwo.Location = new Point(86, 177);
			ButtonTwo.Name = "ButtonTwo";
			ButtonTwo.Size = new Size(77, 81);
			ButtonTwo.TabIndex = 10;
			ButtonTwo.Text = "2";
			ButtonTwo.UseVisualStyleBackColor = true;
			ButtonTwo.Click += ButtonTwo_Click;
			// 
			// ButtonThree
			// 
			ButtonThree.Font = new Font("굴림", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
			ButtonThree.Location = new Point(169, 177);
			ButtonThree.Name = "ButtonThree";
			ButtonThree.Size = new Size(77, 81);
			ButtonThree.TabIndex = 11;
			ButtonThree.Text = "3";
			ButtonThree.UseVisualStyleBackColor = true;
			ButtonThree.Click += ButtonThree_Click;
			// 
			// ButtonSubtract
			// 
			ButtonSubtract.Font = new Font("굴림", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
			ButtonSubtract.Location = new Point(252, 177);
			ButtonSubtract.Name = "ButtonSubtract";
			ButtonSubtract.Size = new Size(79, 81);
			ButtonSubtract.TabIndex = 12;
			ButtonSubtract.Text = "－";
			ButtonSubtract.UseVisualStyleBackColor = true;
			ButtonSubtract.Click += ButtonSubtract_Click;
			// 
			// ButtonAllClear
			// 
			ButtonAllClear.Font = new Font("굴림", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
			ButtonAllClear.Location = new Point(3, 264);
			ButtonAllClear.Name = "ButtonAllClear";
			ButtonAllClear.Size = new Size(77, 83);
			ButtonAllClear.TabIndex = 13;
			ButtonAllClear.Text = "AC";
			ButtonAllClear.UseVisualStyleBackColor = true;
			ButtonAllClear.Click += ButtonAllClear_Click;
			// 
			// ButtonAdd
			// 
			ButtonAdd.Font = new Font("굴림", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
			ButtonAdd.Location = new Point(252, 264);
			ButtonAdd.Name = "ButtonAdd";
			ButtonAdd.Size = new Size(79, 83);
			ButtonAdd.TabIndex = 16;
			ButtonAdd.Text = "＋";
			ButtonAdd.UseVisualStyleBackColor = true;
			ButtonAdd.Click += ButtonAdd_Click;
			// 
			// ButtonResult
			// 
			ButtonResult.Dock = DockStyle.Bottom;
			ButtonResult.Font = new Font("굴림", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
			ButtonResult.Location = new Point(0, 393);
			ButtonResult.Name = "ButtonResult";
			ButtonResult.Size = new Size(334, 68);
			ButtonResult.TabIndex = 17;
			ButtonResult.Text = "=";
			ButtonResult.UseVisualStyleBackColor = true;
			ButtonResult.Click += ButtonResult_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(334, 461);
			Controls.Add(ButtonResult);
			Controls.Add(ButtonLayout);
			Controls.Add(display);
			Name = "Form1";
			Text = "계산기";
			ButtonLayout.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Label display;
		private TableLayoutPanel ButtonLayout;
		private Button ButtonSeven;
		private Button ButtonPoint;
		private Button ButtonEight;
		private Button ButtonNine;
		private Button ButtonDivide;
		private Button ButtonFour;
		private Button ButtonFive;
		private Button ButtonSix;
		private Button ButtonMultiply;
		private Button ButtonOne;
		private Button ButtonTwo;
		private Button ButtonThree;
		private Button ButtonSubtract;
		private Button ButtonAdd;
		private Button ButtonAllClear;
		private Button ButtonZero;
		private Button ButtonResult;
	}
}
