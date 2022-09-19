using System.Collections;
using UX_Design;

namespace UX_Project
{
	internal static class Program
	{
		[STAThread]
		public static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new Form1());

			ArrayList pastPayments = new ArrayList();

			int loanTerm;
			double loanAmt;
			double intRate;
			double monthlyPay;

			Console.WriteLine("Enter loan term: ");
			loanTerm = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter loan amount: $");
			loanAmt = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter interest rate in decimal form:");
			intRate = Convert.ToDouble(Console.ReadLine());

			monthlyPay = findMonthlyPay(loanTerm, loanAmt, intRate);
			pastPayments.Add(monthlyPay);
		}

		//evenutally may need to put this function in a computeMonthlyPayment class
		public static double findMonthlyPay(int t, double a, double r)
		{
			double monthlyPay;
			//calculates interest by dividing the interest rate by 12
			double i = r / 12;
			//calculates the number of payments over loans lifetime by dividing loan term by 12
			double n = t * 12;

			//need to figure out a substitute for exponent operator since C# does not have one
			monthlyPay = a * (i(i + 1) ^ n / ((1 + i) ^ n) - 1);
			return monthlyPay;
		}
	}
}