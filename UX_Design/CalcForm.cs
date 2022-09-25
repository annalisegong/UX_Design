using System.Collections;
using System.Drawing.Design;
using System.Security.Cryptography.X509Certificates;

namespace UX_Design
{
	public partial class CalcForm : Form
	{
		private int loanTerm;
		private double loanAmt;
		private double intRate;

        ArrayList pastPayments = new ArrayList();

        public CalcForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			//assigns loanAmt the user input from txtbox
			loanAmt = Convert.ToDouble(textBox1.Text);
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			//assigns loanTerm the user input from txtbox
			loanTerm = Convert.ToInt32(textBox2.Text);
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			//assigns intRate the user input from txtbox
			intRate = Convert.ToDouble(textBox3.Text);
			
		}

		private void btnCompute_Click(object sender, EventArgs e)
		{
			double monthlyPay;
			double i = intRate / 12;
			
			double n = loanTerm * 12;
			
			double y = 1 + i;

			/*for(double x = 0; x < n; x++)
			{
				y = y * (i + 1);
			}*/
			monthlyPay = loanAmt * (i*(Math.Pow(y, n)) / (Math.Pow(y, n) - 1));
            //monthlyPay = loanTerm * (i*y / (y - 1));
            lblDisplayMP.Text = Convert.ToString(monthlyPay);
            //pastPayments.Add(monthlyPay);
        }
	}
}