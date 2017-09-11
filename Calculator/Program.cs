///////////////////////////31927 Application Development with C# .NET//////////////////////////////
///////////////////////////////////////Assignment 2////////////////////////////////////////////////
//////////////////////////////////Jizhen Zhang 99209126////////////////////////////////////////////

using System;
using System.Windows.Forms;

namespace Calculator
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
}
