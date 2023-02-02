using Impressora;
using PDV_Beta.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV_Beta.Interface.Configuracao
{
    public partial class ConfImpressoras : Form
    {
        XImpressora imp = new XImpressora();
        public ConfImpressoras()
        {
            InitializeComponent();

            comboImpressora.Items.Add("Bematech MP 4200 TH"); //Cod 1
            comboImpressora.Items.Add("Bematech MP 4000 TH"); // Cod 2

            comboQtd.Items.Add("1");
            comboQtd.Items.Add("2");
            comboQtd.Items.Add("3");




        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            
            int status = MP2032.Le_Status();

            MessageBox.Show("A IMPRESSORA RETORNOU ..:  " + status.ToString());

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            int reset = MP2032.PrinterReset();

            MessageBox.Show("A IMPRESSORA RETORNOU ..:  " + reset.ToString());
        }
    }
}
