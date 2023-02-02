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

namespace PDV_Beta.Interface
{
    public partial class BuscaFuncionarios : Form
    {

        private List<Funcionario> funcionarios = new List<Funcionario>();

        private MovSaidasCompleto busca;
        private MovSaidasPizzaria busca2;
        public BuscaFuncionarios(MovSaidasCompleto busca, MovSaidasPizzaria busca2)
        {
            InitializeComponent();
            this.busca = busca;
            this.busca2 = busca2;
        }

        private void BuscaFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
              {
                  e.Handled = true;
              }
        }

       
        private void BuscaPorNome()
        {
            dataListaFuncionarios.Rows.Clear();
            dataListaFuncionarios.Refresh();

            BuscaFuncionariosBLL BLL = new BuscaFuncionariosBLL();

            funcionarios = null;
            funcionarios = BLL.BuscaPorNome(txtNome.Text);

            if (funcionarios != null)
            {
                if (busca != null || busca2 != null)
                {
                    foreach (var indice in funcionarios)
                    {

                        string[] row = new string[] { indice.Codigo, indice.Nome };

                        dataListaFuncionarios.Rows.Add(row);

                    }
                }
            }
        }

        private void BuscaPorCodigo()
        {
            dataListaFuncionarios.Rows.Clear();
            dataListaFuncionarios.Refresh();

            BuscaFuncionariosBLL BLL = new BuscaFuncionariosBLL();
            List<ClienteFornecedor> Cli = new List<ClienteFornecedor>();

            funcionarios = null;
            funcionarios = BLL.BuscaPorCodigo(txtCodigo.Text);


            if (funcionarios != null)
            {
                if (busca != null || busca2 != null)
                {
                    foreach (var indice in funcionarios)
                    {

                        string[] row = new string[] { indice.Codigo, indice.Nome };

                        dataListaFuncionarios.Rows.Add(row);

                    }
                }
            }
        }


        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            BuscaPorCodigo();
            this.Cursor = Cursors.Default;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            BuscaPorNome();
            this.Cursor = Cursors.Default;
        }

        private void dataListaFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (funcionarios != null)
                if (funcionarios.Count > 0)
                    if (e.RowIndex >= 0)
                    {
                        if (busca != null)
                        {
                            busca.txtCodVendedor.Text = funcionarios[e.RowIndex].Codigo;
                            busca.txtNomeVendedor.Text = funcionarios[e.RowIndex].Nome;
                        }
                
                    }

            this.Close();
        }
    }
}
