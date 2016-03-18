using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adgp105
{
    static class Program
    {        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SOAPSerialize.m_Dir = @"C:\Users\quinton.baudoin\Documents\Visual Studio 2015\Projects\adgp105\adgp105\Saves\";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MDIForm());

        }
    }
}
