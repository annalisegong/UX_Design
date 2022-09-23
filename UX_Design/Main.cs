using System.Collections;
using UX_Design;

namespace UX_Project
{
	internal static class Main
	{
		[STAThread]
		public static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new Form1());
		}
	}
}