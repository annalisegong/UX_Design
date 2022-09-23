using System.Collections;

namespace UX_Design
{
	public partial class Form1 : Form
	{
		int loanTerm;
		double loanAmt;
		double intRate;
		double monthlyPay;

        ArrayList pastPayments = new ArrayList();

        public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			//assigns loanAmt the user input from txtbox
			loanAmt = Convert.ToDouble(Console.ReadLine());
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			//assigns loanTerm the user input from txtbox
			loanTerm = Convert.ToInt32(Console.ReadLine());
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			//assigns intRate the user input from txtbox
			intRate = Convert.ToDouble(Console.ReadLine());
		}

		private void btnCompute_Click(object sender, EventArgs e)
		{
			double monthlyPay;
			//calculates interest by dividing the interest rate by 12
			double i = intRate / 12;
			//calculates the number of payments over loans lifetime by dividing loan term by 12
			double n = loanTerm * 12;

			//need to figure out a substitute for exponent operator since C# does not have one
			monthlyPay = loanAmt * (i(i + 1) ^ n / ((1 + i) ^ n) - 1);
			lblDisplayMP.Text = Convert.ToString(monthlyPay);
            pastPayments.Add(monthlyPay);
        }
	}
}