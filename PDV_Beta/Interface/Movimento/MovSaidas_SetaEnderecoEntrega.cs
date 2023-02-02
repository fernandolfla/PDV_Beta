using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV_Beta.Interface.Movimento
{
    public partial class MovSaidas_SetaEnderecoEntrega : Form
    {
        private MovSaidasCompleto busca;
        private MovSaidasPizzaria busca2;
        public MovSaidas_SetaEnderecoEntrega(MovSaidasCompleto busca, MovSaidasPizzaria busca2)
        {
            InitializeComponent();
            ApenasNumerico(txtNumRua);

            this.busca = busca;
            this.busca2 = busca2;

            if(busca != null)
                EntityToTela();
            if (busca2 != null)
                EntityToTela2();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (busca != null)
                TelaToEntity();
            if (busca2 != null)
                TelaToEntity2();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscaCep busca = new BuscaCep(null, null, null, null, this);
            busca.ShowDialog();
        }

        private void EntityToTela2()
        {
            txtNomeCliente.Text = busca2.txtNomeCliente.Text;
            txtEndereco.Text = busca2.saida.Endereco_Entrega;
            txtCep.Text = busca2.saida.CEP_Entrega;
            txtBairro.Text = busca2.saida.Bairro_Entrega;
            txtCidade.Text = busca2.saida.Cidade_Entrega;
            txtComplemento.Text = busca2.saida.Complemento_Entrega;
            txtEstado.Text = busca2.saida.Estado_Entrega;
            txtNumRua.Text = busca2.saida.NumRua_Entrega;
            txtTelefone.Text = busca2.saida.Telefone1;
            txtTelefone2.Text = busca2.saida.Telefone2;
        }

        private void TelaToEntity2()
        {
            busca2.saida.Endereco_Entrega = txtEndereco.Text;
            busca2.saida.CEP_Entrega = txtCep.Text;
            busca2.saida.Bairro_Entrega = txtBairro.Text;
            busca2.saida.Cidade_Entrega = txtCidade.Text;
            busca2.saida.Complemento_Entrega = txtComplemento.Text;
            busca2.saida.Estado_Entrega = txtEstado.Text;
            busca2.saida.NumRua_Entrega = txtNumRua.Text;
        }
        private void EntityToTela()
        {
            txtNomeCliente.Text = busca.txtNomeCliente.Text;
            txtEndereco.Text = busca.saida.Endereco_Entrega;
            txtCep.Text = busca.saida.CEP_Entrega;
            txtBairro.Text = busca.saida.Bairro_Entrega;
            txtCidade.Text = busca.saida.Cidade_Entrega;
            txtComplemento.Text = busca.saida.Complemento_Entrega;
            txtEstado.Text = busca.saida.Estado_Entrega;
            txtNumRua.Text = busca.saida.NumRua_Entrega;
            txtTelefone.Text = busca.saida.Telefone1;
            txtTelefone2.Text = busca.saida.Telefone2;
        }

        private void TelaToEntity()
        {
            busca.saida.Endereco_Entrega = txtEndereco.Text;
            busca.saida.CEP_Entrega = txtCep.Text;
            busca.saida.Bairro_Entrega = txtBairro.Text;
            busca.saida.Cidade_Entrega = txtCidade.Text;
            busca.saida.Complemento_Entrega = txtComplemento.Text;
            busca.saida.Estado_Entrega = txtEstado.Text;
            busca.saida.NumRua_Entrega = txtNumRua.Text;
        }

        private void ApenasNumerico(TextBox txt)
        {
            txt.KeyPress += ApenasValorNumerico;
            txt.Leave += RetornarMascaraNumero;
        }
        private void ApenasValorNumerico(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                    e.Handled = true;
            }
        }

        private void RetornarMascaraNumero(object sender, EventArgs e)
        {
            try
            {
                TextBox txt = (TextBox)sender;
                txt.Text = double.Parse(txt.Text).ToString("0");
            }
            catch (Exception) { }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
