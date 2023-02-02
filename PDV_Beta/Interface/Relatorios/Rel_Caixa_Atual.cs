using Microsoft.Reporting.WinForms;
using PDV_Beta.BLL;
using PDV_Beta.Component;
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

namespace PDV_Beta.Interface.Relatorios
{
    public partial class Rel_Caixa_Atual : Form
    {
        private List<Caixa> cxs = new List<Caixa>();
        public Rel_Caixa_Atual()
        {
            InitializeComponent();

            dateInicio.Value = DateTime.Now;

            MovCaixaBLL BLL = new MovCaixaBLL();
            cxs = BLL.ListaCaixa();


            if(cxs != null)
            foreach (Caixa c in cxs)
            {
                comboCaixas.Items.Add(c.Nome);
            }


            MensagemErro();


        }

        private void MensagemErro()
        {
            if (Erros.GetHaErro())
            {
                MessageBox.Show(Erros.GetMensagemErro() + " " + Erros.GetErroBanco());
                Erros.SetHaErro(false);
            }
        }
        private void Rel_Caixa_Atual_Load(object sender, EventArgs e)
        {

            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string caixa = "0";
            try {
                caixa = cxs[comboCaixas.SelectedIndex].Id;
            }catch { MessageBox.Show("Erro de caixa");  }
            this.relatorioCaixaAtivo.Clear();

            DateTime inicio = dateInicio.Value.Date;

            DataTable data = new DataTable();
            RelatoriosBLL BLL = new RelatoriosBLL();
            data = BLL.Rel_Caixa_Ativo(caixa,inicio);

            if (data != null)
            {
                ReportDataSource dsReport = new ReportDataSource("DataSet1", data);  // Dataset1 refere ao dataset dentro do report
                this.relatorioCaixaAtivo.LocalReport.DataSources.Clear();
                this.relatorioCaixaAtivo.LocalReport.DataSources.Add(dsReport);
                this.relatorioCaixaAtivo.LocalReport.Refresh();

                this.relatorioCaixaAtivo.RefreshReport();
            }
            else
                MessageBox.Show("Não há Vendas no Intervalo Pesquisado");

        }
    }
}
