using UX_Design;

namespace UX_Design
{
    internal static class MainHelpers
    {
        [STAThread]
        public static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new CalcForm());
        }
    }
}