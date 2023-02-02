using PDV_Beta.BLL;
using PDV_Beta.Entity;
using PDV_Beta.Interface.Movimento;
using PDV_Beta.Interface.Relatorios;
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
    public partial class BuscaClienteFornecedor_Vendas : Form
    {
        private int T; //QUAL CAMPO UTILIZAR PARA MANDAR A INFO
        private MovSaidasCompleto busca;
        private MovSaidasPizzaria busca2;
        private Rel_Entregas busca3; 
        private MovSaidasCompleto busca4;// LIVRE
        private MovSaidasCompleto busca5;// LIVRE

        List<ClienteFornecedor> clientes = new List<ClienteFornecedor>();
        List<ClienteFornecedor> clientesF = new List<ClienteFornecedor>();

        public BuscaClienteFornecedor_Vendas(int T, MovSaidasCompleto busca, MovSaidasPizzaria busca2, Rel_Entregas busca3, MovSaidasCompleto busca4, MovSaidasCompleto busca5)
        {
            InitializeComponent();
            this.T = T;
            this.busca = busca;
            this.busca2 = busca2;
            this.busca3 = busca3;
            this.busca4 = busca4;
            this.busca5 = busca5;
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
                if ((busca != null && T == 0) || (busca2 != null && T == 0)) //TODOS OS CLIENTES
                {
                    foreach (var indice in clientes)
                    {

                        string[] row = new string[] { indice.Codigo, indice.Nome };

                        dataListaClientes.Rows.Add(row);

                    }
                }
                if ((busca != null && T == 1) || (busca2 != null && T == 1) || (busca3 != null && T == 1))
                {
                    foreach (var indice in clientes)
                    {
                        if (indice.Tipo.Equals("F")) //SOMENTE FORNECEDORES
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
                if ((busca != null && T == 0) || (busca2 != null && T == 0))  //TODOS OS CLIENTES
                {
                    foreach (var indice in clientes)
                    {

                        string[] row = new string[] { indice.Codigo, indice.Nome };

                        dataListaClientes.Rows.Add(row);

                    }
                }
                if ((busca != null && T == 1) || (busca2 != null && T == 1) || (busca3 != null && T == 1))  //SOMENTE FORNECEDORES
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
                        if (busca != null && T == 0)
                        {
                            busca.txtCodCliente.Text = clientes[e.RowIndex].Codigo;
                            busca.txtNomeCliente.Text = clientes[e.RowIndex].Nome;
                            busca.saida.Cliente = clientes[e.RowIndex].Codigo;
                            busca.saida.Endereco_Entrega = clientes[e.RowIndex].Endereco;
                            busca.saida.Cidade_Entrega = clientes[e.RowIndex].Cidade;
                            busca.saida.Bairro_Entrega = clientes[e.RowIndex].Bairro;
                            busca.saida.Estado_Entrega = clientes[e.RowIndex].Estado;
                            busca.saida.Complemento_Entrega = clientes[e.RowIndex].Complemento;
                            busca.saida.CEP_Entrega = clientes[e.RowIndex].Cep;
                            busca.saida.NumRua_Entrega = clientes[e.RowIndex].NumRua;
                            busca.saida.Telefone1 = clientes[e.RowIndex].Fone1;
                            busca.saida.Telefone2 = clientes[e.RowIndex].Fone2;
                            try { busca.saida.Frete = Convert.ToDecimal(clientes[e.RowIndex].FretePadrao); } catch { busca.saida.Frete = 0; }

                            try { busca.txtFrete.Text = busca.saida.Frete.ToString("C2"); } catch { busca.txtFrete.Text = ""; }
                        }
                        if (busca != null && T == 1)
                        {
                            busca.txtCodTransportadora.Text = clientesF[e.RowIndex].Codigo;
                            busca.txtNomeTransportadora.Text = clientesF[e.RowIndex].Nome;
                        }
                        if (busca2 != null && T == 0)
                        {
                            busca2.txtCodCliente.Text = clientes[e.RowIndex].Codigo;
                            busca2.txtNomeCliente.Text = clientes[e.RowIndex].Nome;
                            busca2.saida.Cliente = clientes[e.RowIndex].Codigo;
                            busca2.saida.Endereco_Entrega = clientes[e.RowIndex].Endereco;
                            busca2.saida.Cidade_Entrega = clientes[e.RowIndex].Cidade;
                            busca2.saida.Bairro_Entrega = clientes[e.RowIndex].Bairro;
                            busca2.saida.Estado_Entrega = clientes[e.RowIndex].Estado;
                            busca2.saida.Complemento_Entrega = clientes[e.RowIndex].Complemento;
                            busca2.saida.CEP_Entrega = clientes[e.RowIndex].Cep;
                            busca2.saida.NumRua_Entrega = clientes[e.RowIndex].NumRua;
                            busca2.saida.Telefone1 = clientes[e.RowIndex].Fone1;
                            busca2.saida.Telefone2 = clientes[e.RowIndex].Fone2;
                            try { busca2.saida.Frete = Convert.ToDecimal(clientes[e.RowIndex].FretePadrao); } catch { busca2.saida.Frete = 0; }

                            try { busca2.txtFrete.Text = busca2.saida.Frete.ToString("C2"); } catch { busca2.txtFrete.Text = ""; }
                        }
                        if (busca2 != null && T == 1)
                        {
                            busca2.txtCodTransportadora.Text = clientesF[e.RowIndex].Codigo;
                            busca2.txtNomeTransportadora.Text = clientesF[e.RowIndex].Nome;
                        }
                        if (busca3 != null && T == 1)
                        {
                            busca3.txtCodTransportadora.Text = clientesF[e.RowIndex].Codigo;
                            busca3.txtNomeTransportadora.Text = clientesF[e.RowIndex].Nome;
                        }
                        if (busca3 != null && T == 1)
                        {
                            //busca3.txtTransportadoraCod.Text = clientesF[e.RowIndex].Codigo;
                        }
                        if (busca4 != null)
                        {
                            //busca4.txtCodCliente.Text = clientes[e.RowIndex].Codigo;
                            //busca4.txtNomeCliente.Text = clientes[e.RowIndex].Nome;
                        }
                        if (busca5 != null)
                        {
                            //busca4.txtCodCliente.Text = clientes[e.RowIndex].Codigo;
                            //busca4.txtNomeCliente.Text = clientes[e.RowIndex].Nome;
                        }

                }

            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            
            CadClientesFornecedores Cliente = new CadClientesFornecedores(txtCodigo.Text, txtNome.Text);
            Cliente.ShowDialog();
        }
    }
}
