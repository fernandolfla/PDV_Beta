using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDV_Beta.Interface;
using PDV_Beta.Entity;
using PDV_Beta.Component;

namespace PDV_Beta
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

            LerArquivo.Ler();

            Login logar = new Login();
            if(logar.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Principal());
            }          
        }
    }
}
