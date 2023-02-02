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
    public partial class BuscaClienteFornecedor : Form
    {

        private CadClientesFornecedores busca;
        private CadProdutos busca2;
        private MovEntradas busca3;
        private int T;
        private ConfTelasVendas busca4;
        List<ClienteFornecedor> clientes = new List<ClienteFornecedor>();
        List<ClienteFornecedor> clientesF = new List<ClienteFornecedor>();

        public BuscaClienteFornecedor(CadClientesFornecedores busca, CadProdutos busca2, MovEntradas busca3, int T, ConfTelasVendas busca4)
        {
            InitializeComponent();
            this.busca = busca;
            this.busca2 = busca2;
            this.busca3 = busca3;
            this.T = T;
            this.busca4 = busca4;
        }

        private void BuscaClienteFornecedor_Load(object sender, EventArgs e)
        {
        }



        private void BuscaPorNome()
        {
            dataListaClientes.Rows.Clear();
            dataListaClientes.Refresh();

            BuscaClienteFornecedorBLL BLL = new BuscaClienteFornecedorBLL();
            clientesF = null;

            clientesF = new List<ClienteFornecedor>();
            clientes = null;
            clientes = BLL.BuscaClienteFornecedorPorNome(txtNome.Text);

            if (clientes != null)
            {
                if (busca != null || busca4 != null)
                {
                    foreach (var indice in clientes)
                    {

                        string[] row = new string[] { indice.Codigo, indice.Nome };

                        dataListaClientes.Rows.Add(row);

                    }
                }
                if (busca2 != null || busca3 != null)
                {
                    foreach (var indice in clientes)
                    {
                        if (indice.Tipo.Equals("F"))
                            clientesF.Add(indice);
                    }
                    foreach (var indice in clientesF)
                    {

                        string[] row = new string[] { indice.Codigo, indice.Nome };

                        dataListaClientes.Rows.Add(row);

                    }

                }


            }
        }

        private void BuscaPorCodigo()
        {
            dataListaClientes.Rows.Clear();
            dataListaClientes.Refresh();

            BuscaClienteFornecedorBLL BLL = new BuscaClienteFornecedorBLL();
            List<ClienteFornecedor> Cli = new List<ClienteFornecedor>();

            clientes = null;
            clientesF = null;
            clientesF = new List<ClienteFornecedor>();
            clientes = BLL.BuscaClienteFornecedorPorCodigo(txtCodigo.Text);


            if (clientes != null)
            {
                if (busca != null || busca4 != null)
                {
                    foreach (var indice in clientes)
                    {

                        string[] row = new string[] { indice.Codigo, indice.Nome };

                        dataListaClientes.Rows.Add(row);

                    }
                }
                if (busca2 != null || busca3 != null)
                {
                    foreach (var indice in clientes)
                    {
                        if (indice.Tipo.Equals("F"))
                            clientesF.Add(indice);
                    }
                    foreach (var indice in clientesF)
                    {

                        string[] row = new string[] { indice.Codigo, indice.Nome };

                        dataListaClientes.Rows.Add(row);

                    }
                }
            }
        }


        private void Codigo_textChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            BuscaPorCodigo();
            this.Cursor = Cursors.Default;
        }

        private void Nome_TextChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            BuscaPorNome();
            this.Cursor = Cursors.Default;
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }



        private void dataListaClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (clientes != null)
                if (clientes.Count > 0)
                    if (e.RowIndex >= 0)
                    {
                        if (busca != null)
                        {
                            busca.EntityToTela(clientes[e.RowIndex]);
                            busca.txtCodigo.Enabled = false;
                            busca.edita = true;
                        }
                        if (busca2 != null)
                        {
                            busca2.txtFornecedor.Text = clientesF[e.RowIndex].Codigo;
                        }
                        if (busca3 != null && T == 0)
                        {
                            busca3.txtCodFornecedor.Text = clientesF[e.RowIndex].Codigo;
                            busca3.txtNomeFornecedor.Text = clientesF[e.RowIndex].Nome;
                        }
                        if (busca3 != null && T == 1)
                        {
                            busca3.txtTransportadoraCod.Text = clientesF[e.RowIndex].Codigo;
                        }
                        if(busca4 != null)
                        {
                            busca4.txtCodCliente.Text = clientes[e.RowIndex].Codigo;
                            busca4.txtNomeCliente.Text = clientes[e.RowIndex].Nome;
                        }

                }

            this.Close();
        }


    }
}
