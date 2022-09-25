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
        double monthlyPay;

       // ArrayList pastPayments = new ArrayList();

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

		/*private void btnCompute_Click(object sender, EventArgs e)
		{
			double i = intRate / 12;
			double n = loanTerm * 12;
			double y = 1 + i;
			monthlyPay = loanAmt * (i*(Math.Pow(y, n)) / (Math.Pow(y, n) - 1));
            txtDisplayMP.Text = Convert.ToString(String.Format("{0:$.##}",monthlyPay));
            //pastPayments.Add(monthlyPay);
        }*/

		private void btnCompute_Click_1(object sender, EventArgs e)
		{
            double i = intRate / 12;
            double n = loanTerm * 12;
            double y = 1 + i;
            monthlyPay = loanAmt * (i * (Math.Pow(y, n)) / (Math.Pow(y, n) - 1));
            txtDisplayMP.Text = Convert.ToString(String.Format("{0:$.##}", monthlyPay));
            //pastPayments.Add(monthlyPay);
        }
    }
}