using PDV_Beta.BLL;
using PDV_Beta.Entity;
using PDV_Beta.Interface.Movimento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV_Beta.Interface.Buscas
{
    public partial class BuscaSaidas : Form
    {
        MovSaidasBLL BLL = new MovSaidasBLL();
        List<Saida> SAIDAS = new List<Saida>();
        MovSaidasCompleto busca;
        MovSaidasPizzaria busca2;
        public BuscaSaidas(MovSaidasCompleto busca, MovSaidasPizzaria busca2)
        {
            InitializeComponent();
            this.busca = busca;
            this.busca2 = busca2;
            dateInicio.Value = DateTime.Now;
            dateFim.Value = DateTime.Now;
        }

        private void BuscaSaidas_Load(object sender, EventArgs e)
        {

        }
        private void txtNF_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSequencia.Text))
                if (string.IsNullOrEmpty(txtComanda.Text))
                    if (string.IsNullOrEmpty(txtMesa.Text))
                        if (string.IsNullOrEmpty(txtPainel.Text))
                            Busca(1, txtNF.Text);         
        }
        private void txtSequencia_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNF.Text))
                if (string.IsNullOrEmpty(txtComanda.Text))
                    if (string.IsNullOrEmpty(txtMesa.Text))
                        if (string.IsNullOrEmpty(txtPainel.Text))
                            Busca(2, txtSequencia.Text);
        }
        private void txtComanda_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSequencia.Text))
                if (string.IsNullOrEmpty(txtNF.Text))
                    if (string.IsNullOrEmpty(txtMesa.Text))
                        if (string.IsNullOrEmpty(txtPainel.Text))
                            Busca(3, txtComanda.Text);
        }

        private void txtMesa_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSequencia.Text))
                if (string.IsNullOrEmpty(txtComanda.Text))
                    if (string.IsNullOrEmpty(txtNF.Text))
                        if (string.IsNullOrEmpty(txtPainel.Text))
                            Busca(4, txtMesa.Text);
        }

        private void txtPainel_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSequencia.Text))
                if (string.IsNullOrEmpty(txtComanda.Text))
                    if (string.IsNullOrEmpty(txtMesa.Text))
                        if (string.IsNullOrEmpty(txtNF.Text))
                            Busca(5, txtPainel.Text);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            BuscaPorData(dateInicio.Value.Date, dateFim.Value.Date);
            this.Cursor = Cursors.Default;
        }

        private void btnEmAberto_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            BuscaAberto();
            this.Cursor = Cursors.Default;
        }
        private void Busca(int indc, string txt)
        {
            dataListaSaidas.Rows.Clear();
            dataListaSaidas.Refresh();

            SAIDAS = null;
            SAIDAS = new List<Saida>();

            SAIDAS = BLL.BuscaSaidas(indc, txt);

            if (SAIDAS != null)
            {
                if (busca != null || busca2 != null)
                {
                    foreach (var indice in SAIDAS)
                    {
                        string rec = "";
                        string canc = "";

                        if (indice.Efetivada_Financ == 1)
                            rec = "OK";
                        if (indice.Nota_cancelada == 1)
                            canc = "OK";

                        string[] row = new string[] { indice.Id, indice.NomeCliente, indice.Mesa,
                        indice.Painel, indice.NumNota, indice.Data.ToString(), indice.Total.ToString("C2"),
                        rec, canc };

                        dataListaSaidas.Rows.Add(row);

                    }
                }
            }
        }

        private void BuscaPorData(DateTime inicio, DateTime fim)
        {
            dataListaSaidas.Rows.Clear();
            dataListaSaidas.Refresh();

            SAIDAS = null;
            SAIDAS = new List<Saida>();

            SAIDAS = BLL.BuscaSaidasPorData(inicio,fim);

            if (SAIDAS != null)
            {
                if (busca != null || busca2 != null)
                {
                    foreach (var indice in SAIDAS)
                    {
                        string rec = "";
                        string canc = "";

                        if (indice.Efetivada_Financ == 1)
                            rec = "OK";
                        if (indice.Nota_cancelada == 1)
                            canc = "OK";

                        string[] row = new string[] { indice.Id, indice.NomeCliente, indice.Mesa,
                        indice.Painel, indice.NumNota, indice.Data.ToString(), indice.Total.ToString("C2"),
                        rec, canc };

                        dataListaSaidas.Rows.Add(row);

                    }
                }
            }
        }


        private void BuscaAberto()
        {
            dataListaSaidas.Rows.Clear();
            dataListaSaidas.Refresh();

            SAIDAS = null;
            SAIDAS = new List<Saida>();

            List<Saida> SAIDAS2 = new List<Saida>();



            DateTime primeiro = new DateTime(2019, 06, 06);
            DateTime ultimo = new DateTime(2025, 01, 01);

            SAIDAS2 = BLL.BuscaSaidasPorData(primeiro, ultimo);

            if(SAIDAS2 != null)
                foreach(var l in SAIDAS2)
                {
                    if(l.Efetivada_Financ == 0)
                    {
                        SAIDAS.Add(l);
                    }
                }

            if (SAIDAS != null)
            {
                if (busca != null || busca2 != null)
                {
                    foreach (var indice in SAIDAS)
                    {
                        string rec = "";
                        string canc = "";

                        if (indice.Efetivada_Financ == 1)
                            rec = "OK";
                        if (indice.Nota_cancelada == 1)
                            canc = "OK";

                        string[] row = new string[] { indice.Id, indice.NomeCliente, indice.Mesa,
                        indice.Painel, indice.NumNota, indice.Data.ToString(), indice.Total.ToString("C2"),
                        rec, canc };

                        dataListaSaidas.Rows.Add(row);

                    }
                }
            }
        }
        private void dataListaSaidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SAIDAS != null)
                if (SAIDAS.Count > 0)
                    if (e.RowIndex >= 0)
                    {
                        if (busca != null)
                            if (e.RowIndex >= 0)
                            {
                                SAIDAS[e.RowIndex].Lista_produtos = BLL.BuscaSaidas_Produtos(SAIDAS[e.RowIndex].Id);
                                busca.EntityToTela(SAIDAS[e.RowIndex]);
                            }
                        if (busca2 != null)
                            if (e.RowIndex >= 0)
                            {
                                SAIDAS[e.RowIndex].Lista_produtos = BLL.BuscaSaidas_Produtos(SAIDAS[e.RowIndex].Id);
                                busca2.EntityToTela(SAIDAS[e.RowIndex]);
                            }
                    }

            this.Close();
        }


    }
}
