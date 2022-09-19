using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UX_Project
{
	internal class PastPayments
	{
		public PastPayments()
		{
		}

		public void display(ArrayList pastPayments)
		{
			//main heading for past payments page
			Console.WriteLine("Past Monthly Payments");

			for (int i = 0; i <= pastPayments.length(); i++) // need to find equivalent method to .length()
			{
				Console.WriteLine(pastPayments[i]);
			}
		}
	}
}
