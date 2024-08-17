namespace Basic_Calculator
{
	public partial class Form1 : Form
	{
		enum Operators
		{
			None,
			Add,
			Subtract,
			Multiply,
			Divide,
			Result
		}

		Operators currentOperator = Operators.None;
		bool operatorsChangeFlag = false;
		long firstOperand = 0;
		long secondOperand = 0;
		bool isDivideError = false;
		public Form1()
		{
			InitializeComponent();
		}

		private void ButtonResult_Click(object sender, EventArgs e)
		{
			if (isDivideError)
				return;

			secondOperand = long.Parse(display.Text);
			if (currentOperator == Operators.Add)
			{
				firstOperand += secondOperand;
				display.Text = firstOperand.ToString();
			}
			else if (currentOperator == Operators.Subtract)
			{
				firstOperand -= secondOperand;
				display.Text = firstOperand.ToString();
			}
			else if (currentOperator == Operators.Multiply)
			{
				firstOperand *= secondOperand;
				display.Text = firstOperand.ToString();
			}
			else if (currentOperator == Operators.Divide)
			{
				if (secondOperand == 0)
				{
					display.Text = "0으로 나눌 수 없습니다";
					isDivideError = true;
				}
				else
				{
					firstOperand /= secondOperand;
					display.Text = firstOperand.ToString();
				}
			}
		}

		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			if (isDivideError)
				return;
			firstOperand = long.Parse(display.Text);
			currentOperator = Operators.Add;
			operatorsChangeFlag = true;
		}

		private void ButtonSubtract_Click(object sender, EventArgs e)
		{
			if (isDivideError)
				return;
			firstOperand = long.Parse(display.Text);
			currentOperator = Operators.Subtract;
			operatorsChangeFlag = true;
		}

		private void ButtonMultiply_Click(object sender, EventArgs e)
		{
			if (isDivideError)
				return;
			firstOperand = long.Parse(display.Text);
			currentOperator = Operators.Multiply;
			operatorsChangeFlag = true;
		}

		private void ButtonDivide_Click(object sender, EventArgs e)
		{
			if (isDivideError)
				return;
			firstOperand = long.Parse(display.Text);
			currentOperator = Operators.Divide;
			operatorsChangeFlag = true;
		}

		private void ButtonAllClear_Click(object sender, EventArgs e)
		{
			firstOperand = 0;
			secondOperand = 0;
			currentOperator = Operators.None;
			display.Text = "0";
			isDivideError = false;
		}

		private void ButtonPoint_Click(object sender, EventArgs e)
		{

		}
		private void OperatorsChangeFlag()
		{
			if (operatorsChangeFlag)
			{
				display.Text = "";
				operatorsChangeFlag = false;
			}
		}
		private void ChangeText(string strNumber)
		{
			long num = long.Parse(strNumber);
			display.Text = num.ToString();
		}
		private void ButtonZero_Click(object sender, EventArgs e)
		{
			if (isDivideError)
				return;
			OperatorsChangeFlag();
			string strNumber = display.Text += "0";
			ChangeText(strNumber);
		}

		private void ButtonOne_Click(object sender, EventArgs e)
		{
			if (isDivideError)
				return;
			OperatorsChangeFlag();
			string strNumber = display.Text += "1";
			ChangeText(strNumber);
		}

		private void ButtonTwo_Click(object sender, EventArgs e)
		{
			if (isDivideError)
				return;
			OperatorsChangeFlag();
			string strNumber = display.Text += "2";
			ChangeText(strNumber);
		}

		private void ButtonThree_Click(object sender, EventArgs e)
		{
			if (isDivideError)
				return;
			OperatorsChangeFlag();
			string strNumber = display.Text += "3";
			ChangeText(strNumber);
		}

		private void ButtonFour_Click(object sender, EventArgs e)
		{
			if (isDivideError)
				return;
			OperatorsChangeFlag();
			string strNumber = display.Text += "4";
			ChangeText(strNumber);
		}

		private void ButtonFive_Click(object sender, EventArgs e)
		{
			if (isDivideError)
				return;
			OperatorsChangeFlag();
			string strNumber = display.Text += "5";
			ChangeText(strNumber);
		}

		private void ButtonSix_Click(object sender, EventArgs e)
		{
			if (isDivideError)
				return;
			OperatorsChangeFlag();
			string strNumber = display.Text += "6";
			ChangeText(strNumber);
		}

		private void ButtonSeven_Click(object sender, EventArgs e)
		{
			if (isDivideError)
				return;
			OperatorsChangeFlag();
			string strNumber = display.Text += "7";
			ChangeText(strNumber);
		}

		private void ButtonEight_Click(object sender, EventArgs e)
		{
			if (isDivideError)
				return;
			OperatorsChangeFlag();
			string strNumber = display.Text += "8";
			ChangeText(strNumber);
		}

		private void ButtonNine_Click(object sender, EventArgs e)
		{
			if (isDivideError)
				return;
			OperatorsChangeFlag();
			string strNumber = display.Text += "9";
			ChangeText(strNumber);
		}
	}
}
