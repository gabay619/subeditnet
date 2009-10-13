using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SubEditNET.Loader;
using SubEditNET.Logger;

namespace SubEditNET
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //initialize logger
            DebugLogger debugLogger = DebugLogger.Instance;
            //set if logging is activated
            debugLogger.setStatus(Status.ENABLED);
            //set the logger level
            debugLogger.setLevel(Level.DEBUG);
           // debugLogger.add("Log initalized with Level: "+debugLogger.getLevel(), Level.DEBUG);


            //initialize loader
            SRTLoader fileLoader = SRTLoader.Instance;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm mainForm = new MainForm();

            mainForm.DebugLogger.Text = debugLogger.getCurrentLog();

            Application.Run(mainForm);
        }
    }
}
