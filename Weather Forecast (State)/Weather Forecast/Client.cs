using System;
using System.Windows.Forms;

namespace CT7Q2_Weather
{
    internal static class Client
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Context
            Form context = new CfrmWeather();

            //Start app
            Application.Run(context);
        } //Main
    }
}