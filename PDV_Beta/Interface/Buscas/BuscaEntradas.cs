using PDV_Beta.BLL;
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

namespace PDV_Beta.Interface
{
    public partial class BuscaEntradas : Form
    {
        private MovEntradas busca;
        private List<Entradas> entradas = new List<Entradas>();
        public BuscaEntradas(MovEntradas busca)
        {
            InitializeComponent();
            this.busca = busca;
            dateFim.Value = DateTime.Now;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            if (string.IsNullOrEmpty(txtNumNf.Text))
                Buscar(true);
            else Buscar(false);
            this.Cursor = Cursors.Default;
        }


        private void Buscar(bool DataNF)
        {
            dataListaEntradas.Rows.Clear();
            dataListaEntradas.Refresh();

            BuscaEntradasBLL BLL = new BuscaEntradasBLL();
            entradas = null;
            if (DataNF)
                entradas = BLL.BuscaEntrada(dateInicio.Value, dateFim.Value);
            else
                entradas = BLL.BuscaEntradaNF(txtNumNf.Text);

            if (entradas != null)
            {
                foreach (var indice in entradas)
                {

                    string[] row = new string[] { indice.NumNota, indice.NomeFornecedor, indice.Data, indice.Total.ToString("C2") };

                    dataListaEntradas.Rows.Add(row);

                }
            }
        }

        private void dataListaEntradas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (entradas != null)
                if (entradas.Count > 0)
                    if (e.RowIndex >= 0)
                    {
                        if (busca != null)
                        {
                            BuscaEntradasBLL BLL = new BuscaEntradasBLL();
                            entradas[e.RowIndex].listagrid = BLL.BuscaLinhas(entradas[e.RowIndex].Id);
                            busca.EntityToTela(entradas[e.RowIndex]);
                            busca.edita = true;
                        }
                    }

            this.Close();
        }
    }
}
