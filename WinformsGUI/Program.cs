using ServiceLayer;

namespace WinformsGUI
{
    internal static class Program
    {
        private static LogicLayer logicLayer = new LogicLayer();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new VäljAnvändare(logicLayer));
        }
    }
}