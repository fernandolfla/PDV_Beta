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
    

    public partial class BuscaCep : Form
    {
        private CadFuncionarios busca;
        private CadClientesFornecedores busca2;
        private CadEmpresa busca3;
        private CadFilial busca4;
        private MovSaidas_SetaEnderecoEntrega busca5;

        public BuscaCep(CadFuncionarios busca,CadClientesFornecedores busca2,CadEmpresa busca3,CadFilial busca4, MovSaidas_SetaEnderecoEntrega busca5)
        {
            InitializeComponent();
            this.busca = busca;
            this.busca2 = busca2;
            this.busca3 = busca3;
            this.busca4 = busca4;
            this.busca5 = busca5;
        }

        private void SomenteNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                if (busca != null)
                    BuscarCepFuncionarios();
                if (busca2 != null)
                    BuscarCepClientes();
                if (busca3 != null)
                    BuscarCepEmpresa();
                if (busca4 != null)
                    BuscarCepFilial();
                if (busca5 != null)
                    BuscarCepTelaVendas();

                this.Close();
            }

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (busca != null)
                BuscarCepFuncionarios();
            if(busca2 != null)
                 BuscarCepClientes();
            if (busca3 != null)
                BuscarCepEmpresa();
            if (busca4 != null)
                BuscarCepFilial();
            if (busca5 != null)
                BuscarCepTelaVendas();

            this.Close();
        }

        private void AtualizaCep_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void BuscaCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                if (busca != null)
                    BuscarCepFuncionarios();
                if (busca2 != null)
                    BuscarCepClientes();
                if (busca3 != null)
                    BuscarCepEmpresa();
                if (busca4 != null)
                    BuscarCepFilial();
                if (busca5 != null)
                    BuscarCepTelaVendas();

                this.Close();
            }
        }

        private void BuscarCepFuncionarios()
        {
            BuscaCepBLL BLL = new BuscaCepBLL();
            Endereco end = new Endereco();
            end = BLL.BuscaCep(txtCEP.Text);

            if (end != null)
            {
                busca.txtCep.Text = end.Cep;
                busca.txtEndereco.Text = end.Rua;
                busca.txtBairro.Text = end.Bairro;
                busca.txtCidade.Text = end.Cidade;
                busca.txtEstado.Text = end.Sigla;

            }
        }

        private void BuscarCepClientes()
        {
            BuscaCepBLL BLL = new BuscaCepBLL();
            Endereco end = new Endereco();
            end = BLL.BuscaCep(txtCEP.Text);

            if (end != null)
            {
                busca2.txtCep.Text = end.Cep;
                busca2.txtEndereco.Text = end.Rua;
                busca2.txtBairro.Text = end.Bairro;
                busca2.txtCidade.Text = end.Cidade;
                busca2.txtEstado.Text = end.Sigla;

            }
        }

        private void BuscarCepEmpresa()
        {
            BuscaCepBLL BLL = new BuscaCepBLL();
            Endereco end = new Endereco();
            end = BLL.BuscaCep(txtCEP.Text);

            if (end != null)
            {
                busca3.txtCep.Text = end.Cep;
                busca3.txtEndereco.Text = end.Rua;
                busca3.txtBairro.Text = end.Bairro;
                busca3.txtCidade.Text = end.Cidade;
                busca3.txtEstado.Text = end.Sigla;

            }
        }


        private void BuscarCepFilial()
        {
            BuscaCepBLL BLL = new BuscaCepBLL();
            Endereco end = new Endereco();
            end = BLL.BuscaCep(txtCEP.Text);

            if (end != null)
            {
                busca4.txtCep.Text = end.Cep;
                busca4.txtEndereco.Text = end.Rua;
                busca4.txtBairro.Text = end.Bairro;
                busca4.txtCidade.Text = end.Cidade;
                busca4.txtEstado.Text = end.Sigla;

            }
        }

        private void BuscarCepTelaVendas()
        {
            BuscaCepBLL BLL = new BuscaCepBLL();
            Endereco end = new Endereco();
            end = BLL.BuscaCep(txtCEP.Text);

            if (end != null)
            {
                busca5.txtCep.Text = end.Cep;
                busca5.txtEndereco.Text = end.Rua;
                busca5.txtBairro.Text = end.Bairro;
                busca5.txtCidade.Text = end.Cidade;
                busca5.txtEstado.Text = end.Sigla;

            }
        }

    }
}
