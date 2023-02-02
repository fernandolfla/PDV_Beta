using Microsoft.Reporting.WinForms;
using PDV_Beta.BLL;
using PDV_Beta.Component;
using PDV_Beta.Seguranca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV_Beta.Interface.Relatorios
{
    public partial class Rel_Vendas : Form
    {
        public Rel_Vendas()
        {
            InitializeComponent();

            dateInicio.Value = DateTime.Now;
            dateFim.Value = DateTime.Now;
        }

        private void MensagemErro()
        {
            if (Erros.GetHaErro())
            {
                MessageBox.Show(Erros.GetMensagemErro() + " " + Erros.GetErroBanco());
                Erros.SetHaErro(false);
            }
        }

        private void Rel_Vendas_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.relatorioVendas.Clear();

            DateTime inicio = dateInicio.Value.Date;
            DateTime fim = dateFim.Value.Date; ;

            DataTable data = new DataTable();
            RelatoriosBLL BLL = new RelatoriosBLL();
            data = BLL.Rel_Vendas(inicio, fim);

            if (data != null)
            {
                ReportDataSource dsReport = new ReportDataSource("DataSet1", data);  // Dataset1 refere ao dataset dentro do report
                this.relatorioVendas.LocalReport.DataSources.Clear();
                this.relatorioVendas.LocalReport.DataSources.Add(dsReport);
                this.relatorioVendas.LocalReport.Refresh();

                this.relatorioVendas.RefreshReport();
            }
            else
                MessageBox.Show("Não há Vendas no Intervalo Pesquisado");



            MensagemErro();
        }




    }
}
