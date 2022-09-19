using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UX_Project
{
	internal class Login
	{
		String username;
		String password;

		public Login()
		{
			//assigns values to username and password
			Console.WriteLine("username:");
			username = Console.ReadLine();
			Console.WriteLine("password;");
			password = Console.ReadLine();
		}
	}
}
