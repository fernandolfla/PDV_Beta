using Microsoft.Reporting.WinForms;
using PDV_Beta.BLL;
using PDV_Beta.Component;
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
    public partial class Rel_Entregas : Form
    {
        public Rel_Entregas()
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
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.relatorioEntregas.Clear();

            string transportadora = null;

            if(!string.IsNullOrEmpty(txtCodTransportadora.Text))
                transportadora = txtCodTransportadora.Text;
            

            DateTime inicio = dateInicio.Value;
            DateTime fim = dateFim.Value.Date; ;

            DataTable data = new DataTable();
            RelatoriosBLL BLL = new RelatoriosBLL();
            data = BLL.Rel_Entregas(inicio, fim,transportadora);

            if (data != null)
            {
                ReportDataSource dsReport = new ReportDataSource("DataSet1", data);  // Dataset1 refere ao dataset dentro do report
                this.relatorioEntregas.LocalReport.DataSources.Clear();
                this.relatorioEntregas.LocalReport.DataSources.Add(dsReport);
                this.relatorioEntregas.LocalReport.Refresh();

                this.relatorioEntregas.RefreshReport();
            }
            else
                MessageBox.Show("Não há Vendas no Intervalo Pesquisado");



            MensagemErro();
        }

        private void btnTransportadora_Click(object sender, EventArgs e)
        {
            // 1 = PARA BUSCA DE TRANSPORTADORA
            BuscaClienteFornecedor_Vendas busca = new BuscaClienteFornecedor_Vendas(1, null, null, this, null, null);
            busca.ShowDialog();
        }
    }
}

