using PDV_Beta.BLL;
using PDV_Beta.Entity;
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

namespace PDV_Beta.Interface
{
    public partial class CadClientesFornecedores : Form
    {
        private string cliente;
        public CadClientesFornecedores(string cliente, string nome)
        {
            
            InitializeComponent();
            this.cliente = cliente;

            if(cliente != null)
                txtCodigo.Text = cliente;

            comboTipo.SelectedIndex = 0;
            comboFisicaJuridica.SelectedIndex = 0;


            List<Operacoes> CFOP = new List<Operacoes>();

            CadClientesFornecedoresBLL BLL = new CadClientesFornecedoresBLL();

            comboOpEntrada.Items.Add("0");
            comboOpSaida.Items.Add("0");

            CFOP = BLL.ListaOperacoes();
            if(CFOP != null)
            {
                foreach(Operacoes op in CFOP)
                {
                    if (op.Tipo == 0)
                        comboOpEntrada.Items.Add(op.CFOP);
                    else comboOpSaida.Items.Add(op.CFOP);
                }
            }


        }

        public bool edita = false;

       
       private void MensagemErro()
        {
            if (Erros.GetHaErro())
            {
                MessageBox.Show("Ouve um erro a conectar ao banco de dados, reinicie o programa, caso persista entre em contato com o suporte. ERRO = " + Erros.GetErroBanco());
                Erros.SetHaErro(false);
            }
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            BuscaCep busca = new BuscaCep(null,this,null,null,null);

            busca.ShowDialog();
        }

        private void PJouPF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFisicaJuridica.SelectedIndex == 0)
            {
                txtFantasia.Visible = false;
                labelFantasia.Visible = false;
                labelInscricao.Text = "RG";
                labelMunicipal.Visible = false;
                txtInscricaoMunicipal.Visible = false;
                labelCNPJ.Text = "CPF";
                txtCNPJ.Mask = "00000000000";
            }
            else
            {
                txtFantasia.Visible = true;
                labelFantasia.Visible = true;
                labelInscricao.Text = "Insc. Estadual";
                labelMunicipal.Visible = true;
                txtInscricaoMunicipal.Visible = true;
                labelCNPJ.Text = "CNPJ";
                txtCNPJ.Mask = "00000000000000";
            }
            
        }

        private void LimiteCred_Enter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= txtLimiteCred.Text.Length - 1; i++)
            {
                if ((txtLimiteCred.Text[i] >= '0' &&
                    txtLimiteCred.Text[i] <= '9') ||
                    txtLimiteCred.Text[i] == ',')
                {
                    x += txtLimiteCred.Text[i];
                }
            }
            txtLimiteCred.Text = x;
            txtLimiteCred.SelectAll();
        }

        private void LimiteCred_Leave(object sender, EventArgs e)
        {
            MoedaToTextBoxLimiteCred();
        }

        private void MoedaToTextBoxLimiteCred()
        {
            try { txtLimiteCred.Text = Convert.ToDouble(txtLimiteCred.Text).ToString("C"); }  catch (Exception)  {  }
            try { txtFretePadrao.Text = Convert.ToDouble(txtFretePadrao.Text).ToString("C"); } catch (Exception) { }
        }

        private void LimiteCred_Keypress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtLimiteCred.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadClientesFornecedoresBLL BLL = new CadClientesFornecedoresBLL();
            ClienteFornecedor cli = new ClienteFornecedor();
            int result = -2;

            cli = TelaToEntity();

            result = BLL.CadastraFornecedor(cli, edita);

            switch(result)
            {
                    case 1:
                        if (edita)
                            MessageBox.Show("Cadastro Editado com Sucesso");
                        else MessageBox.Show("Cadastro Realizado com Sucesso");
                        break;
                    case 2:  MessageBox.Show("O código ou Telefone já existe, tente outro código ou clique na seta de Prox Código");
                        break;
                    case 3: MessageBox.Show("Verifique os campos Obrigatórios");
                        break;
                    case 4: MessageBox.Show("O primeiro Digito do Nome precisa ser uma Letra");
                    break;
                    default: MessageBox.Show("Ocorreram Erros ao cadastrar o Cliente, Tente Novamente");
                        break;
           
            }    

            LimpaTela();

            MensagemErro();

        }

        private void LimpaTela()
        {
            txtCodigo.Text = "";
            comboTipo.SelectedIndex = 0;
            comboFisicaJuridica.SelectedIndex = 0;
            txtNome.Text = "";
            txtFantasia.Text = "";
            txtEndereco.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtCep.Text = "";
            txtNumRua.Text = "";
            txtCNPJ.Text = "";
            txtInscricao.Text = "";
            txtInscricaoMunicipal.Text = "";
            txtTelefone.Text = "";
            txtTelefone2.Text = "";
            txtDiaVencConta.Text = "";
            txtEmail.Text = "";
            txtEmailFinanceiro.Text = "";
            txtLimiteCred.Text = "";
            txtRuaProx.Text = "";
            txtReferencia.Text = "";
            comboOpSaida.Text = "0";
            comboOpEntrada.Text = "0";
            txtObservacoes.Text = "";
            checkAtivo.Checked = true;
            checkTemConta.Checked = false;
            checkCompraParcelado.Checked = false;
            txtFretePadrao.Text = "";
            edita = false;
            
        }

        private ClienteFornecedor TelaToEntity()
        {
            ClienteFornecedor cli = new ClienteFornecedor();


            cli.Codigo = txtCodigo.Text;
            cli.Tipo = comboTipo.Text[0].ToString();
            cli.Fisica_Juridica = comboFisicaJuridica.Text[0].ToString();
            cli.Nome = txtNome.Text;
            cli.Fantasia = txtFantasia.Text;
            cli.Endereco = txtEndereco.Text;
            cli.Complemento = txtComplemento.Text;
            cli.Bairro = txtBairro.Text;
            cli.Cidade = txtCidade.Text;
            cli.Estado = txtEstado.Text;
            cli.Cep = txtCep.Text;
            cli.NumRua = txtNumRua.Text;
            cli.CNPJ = txtCNPJ.Text;
            cli.Inscricao = txtInscricao.Text;
            cli.InscricaoMunicipal = txtInscricaoMunicipal.Text;
            cli.Fone1 = txtTelefone.Text;
            cli.Fone2 = txtTelefone2.Text;
            if (string.IsNullOrEmpty(txtDiaVencConta.Text))
                cli.DiaFechamentoConta = "1";
            else cli.DiaFechamentoConta = txtDiaVencConta.Text;
            cli.Email = txtEmail.Text;
            cli.EmailFinanceiro = txtEmailFinanceiro.Text;
            cli.LimiteCredito = txtLimiteCred.Text.Replace(".", "").Replace("R$", "").Replace(",", ".");
            cli.Rua_Proxima1 = txtRuaProx.Text;
            cli.Rua_Proxima2 = txtReferencia.Text;
            cli.OperacaoPadraoSaida = comboOpSaida.Text;
            cli.OperacaoPadraoEntrada = comboOpEntrada.Text;
            cli.Observacoes = txtObservacoes.Text;
            cli.FretePadrao = txtFretePadrao.Text.Replace(".", "").Replace("R$", "").Replace(",", ".");
            if (checkAtivo.Checked)
                cli.Ativo = 1;
            else cli.Ativo = 0;

            if (checkTemConta.Checked)
                cli.TemConta = 1;
            else cli.TemConta = 0;

            if (checkCompraParcelado.Checked)
                cli.CompraParcelado = 1;
            else cli.CompraParcelado = 0;

            return cli;
        }

        public void EntityToTela(ClienteFornecedor cli)
        {
            txtCodigo.Text = cli.Codigo;
            if(cli.Tipo.Equals("C"))
                comboTipo.SelectedIndex = 0;
            else comboTipo.SelectedIndex = 1;
            if(cli.Fisica_Juridica.Equals("F"))
                comboFisicaJuridica.SelectedIndex = 0;
            else comboFisicaJuridica.SelectedIndex = 1;

            txtNome.Text = cli.Nome;
            txtFantasia.Text = cli.Fantasia;
            txtEndereco.Text = cli.Endereco;
            txtComplemento.Text = cli.Complemento;
            txtBairro.Text = cli.Bairro;
            txtCidade.Text = cli.Cidade;
            txtEstado.Text = cli.Estado;
            txtCep.Text = cli.Cep;
            txtNumRua.Text = cli.NumRua;
            txtCNPJ.Text = cli.CNPJ;
            txtInscricao.Text = cli.Inscricao;
            txtInscricaoMunicipal.Text = cli.InscricaoMunicipal;
            txtTelefone.Text = cli.Fone1;
            txtTelefone2.Text = cli.Fone2;
            txtDiaVencConta.Text = cli.DiaFechamentoConta;
            txtEmail.Text = cli.Email;
            txtEmailFinanceiro.Text = cli.EmailFinanceiro;
            txtLimiteCred.Text = cli.LimiteCredito;
            txtFretePadrao.Text = cli.FretePadrao;
            txtRuaProx.Text = cli.Rua_Proxima1;
            txtReferencia.Text = cli.Rua_Proxima2;
            comboOpSaida.Text = cli.OperacaoPadraoSaida;
            comboOpEntrada.Text = cli.OperacaoPadraoEntrada;
            txtObservacoes.Text = cli.Observacoes;

            if (cli.Ativo == 1)
                checkAtivo.Checked = true;
            else checkAtivo.Checked = false;

            if (cli.TemConta == 1)
                checkTemConta.Checked = true;
            else checkTemConta.Checked = false;

            if (cli.CompraParcelado == 1)
                checkCompraParcelado.Checked = true;
            else checkCompraParcelado.Checked = false;

            MoedaToTextBoxLimiteCred(); //Converte para moeda o campo txt


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            edita = false;
            txtCodigo.Enabled = true;
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            
            txtCodigo.Enabled = false;
            ClienteFornecedor cli = new ClienteFornecedor();
            CadClientesFornecedoresBLL BLL = new CadClientesFornecedoresBLL();

            cli = TelaToEntity();

            cli = BLL.BuscaAntClienteFornecedor(cli);

            if (cli != null)
            {
                LimpaTela();
                EntityToTela(cli);
            }

            edita = true;
            MensagemErro();
        }

        private void btnProx_Click(object sender, EventArgs e)
        {
           
            txtCodigo.Enabled = false;
            ClienteFornecedor cli = new ClienteFornecedor();
            CadClientesFornecedoresBLL BLL = new CadClientesFornecedoresBLL();

            cli = TelaToEntity();

            cli = BLL.BuscaProxClienteFornecedor(cli);

            if(cli != null)
            {
                LimpaTela();
                EntityToTela(cli);
            }

            edita = true;
            MensagemErro();
        }

        private void SomenteNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Realmente deseja Excluir? Marque como inativo para que não apareça mais nas telas ve compra e venda ", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                CadClientesFornecedoresBLL BLL = new CadClientesFornecedoresBLL();
                if (BLL.ApagaClienteFornecedor(txtCodigo.Text))
                {
                    MessageBox.Show("Cliente / Fornecedor Deletado com Sucesso");
                }
                else MessageBox.Show("O Cliente ou fornecedor possui notas ou compras e não será possivel apagar, marque-o como Inativo");

            }

            LimpaTela();
            MensagemErro();
        }

        private void btnProxCodLivre_Click(object sender, EventArgs e)
        {
            if (!edita)
            {
                CadClientesFornecedoresBLL BLL = new CadClientesFornecedoresBLL();

                txtCodigo.Text = BLL.BuscaProxCodLivre();
            }
            MensagemErro();
        }

        private void btnBuscarCli_Click(object sender, EventArgs e)
        {
            BuscaClienteFornecedor busca = new BuscaClienteFornecedor(this,null,null,0,null);

            busca.ShowDialog();

        }

        private void txtFretePadrao_Enter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= txtFretePadrao.Text.Length - 1; i++)
            {
                if ((txtFretePadrao.Text[i] >= '0' &&
                    txtFretePadrao.Text[i] <= '9') ||
                    txtFretePadrao.Text[i] == ',')
                {
                    x += txtFretePadrao.Text[i];
                }
            }
            txtFretePadrao.Text = x;
            txtFretePadrao.SelectAll();
        }

        private void txtFretePadrao_Leave(object sender, EventArgs e)
        {
            MoedaToTextBoxLimiteCred();
        }

        private void txtFretePadrao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtFretePadrao.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }
    }
}
