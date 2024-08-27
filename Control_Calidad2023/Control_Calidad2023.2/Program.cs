using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Control_Calidad2023.Formularios;

namespace Control_Calidad2023
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMenu());
        }
    }
}
