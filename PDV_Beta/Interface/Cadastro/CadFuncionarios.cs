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
    public partial class CadFuncionarios : Form
    {
        public CadFuncionarios()
        {
            InitializeComponent();

            List<Filial> Fil = new List<Entity.Filial>();
            CadFuncionariosBLL BLL = new CadFuncionariosBLL();
            Fil = BLL.ListaFiliais();
            if(Fil != null)
            {
                foreach(Filial fils in Fil)
                {
                    comboFilial.Items.Add(fils.Codigo);
                }
                
            }
           
        }

        private void MensagemErro()
        {
            if (Erros.GetHaErro())
            {
                MessageBox.Show("Ouve um erro a conectar ao banco de dados, reinicie o programa, caso persista entre em contato com o suporte. ERRO = " + Erros.GetErroBanco());
                Erros.SetHaErro(false);
            }
        }


        private void CadFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void SomenteNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            CadFuncionariosBLL BLL = new CadFuncionariosBLL();
            funcionario = TelaToEntity();
            int result = -2;

            result = BLL.CadastraFuncionarios(funcionario);
                if(result > 0)
                {

                    if(string.IsNullOrEmpty(txtCodigo.Text))
                    {
                        MessageBox.Show("Funcionario Salvo com Sucesso, Para Logar no sistema utilize o código  " + result);
                    }
                else MessageBox.Show("Funcionario Salvo com Sucesso");

                LimpaTela();
            }
                else
                    MessageBox.Show("Erro ao Cadastrar Funcionario, Verifique campos obrigatorios");


            MensagemErro();
        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            CadFuncionariosBLL BLL = new CadFuncionariosBLL();
            Funcionario fun = new Funcionario();

            fun = TelaToEntity();

            fun = BLL.BuscaAntFuncionarios(fun);

            if (fun != null)
            {
                LimpaTela();
                fun.Senha = "";
                EntityToTela(fun);
            }
            else MessageBox.Show("Erro ao buscar Funcionario, por favor reinicie o programa");
            MensagemErro();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            CadFuncionariosBLL BLL = new CadFuncionariosBLL();
            Funcionario fun = new Funcionario();

            fun = TelaToEntity();

            fun =  BLL.BuscaProxFuncionarios(fun);
            if (fun != null)
            {
                LimpaTela();
                fun.Senha = "";
                EntityToTela(fun);
            }
            else MessageBox.Show("Erro ao buscar Funcionario, por favor reinicie o programa");

            MensagemErro();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {     
            DialogResult Result = MessageBox.Show("Realmente deseja Excluir? Marque como inativo ", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                CadFuncionariosBLL BLL = new CadFuncionariosBLL();
                switch(BLL.ApagaFuncionario(txtCodigo.Text))
                {
                    case 0: MessageBox.Show("Erro ao apagar Usuario");
                        break;
                    case 1: MessageBox.Show("O Funcionario 1 é master e não pode ser deletado");
                        break;
                    case 2: MessageBox.Show("Não pode excluir o usuario ativo, logue com outra conta de administrador");
                        break;
                    case 3: MessageBox.Show("Funcionario Apagado");
                            LimpaTela();
                        break;
                    default: MessageBox.Show("Houve algum erro ao tentar deletar o usuario");
                        break;     
                }
            }
            MensagemErro();
        }

        private Funcionario TelaToEntity()
        {
            Funcionario fun = new Funcionario();

            fun.Codigo = txtCodigo.Text;
            fun.Nome = txtNome.Text;
            fun.Apelido = txtApelido.Text;
            fun.Senha = txtSenha.Text;
            fun.Bairro = txtBairro.Text;
            fun.Cargo = txtCargo.Text;
            fun.Celular = txtCelular.Text;
            fun.Cep = txtCep.Text;
            fun.Cidade = txtCidade.Text;
            fun.Carteira_Trabalho = txtCLT.Text;
            fun.CPF = txtCPF.Text;
            fun.Admissao = txtDataAdmissao.Text;
            fun.Endereco = txtEndereco.Text;
            fun.Estado = txtEstado.Text;
            fun.Identidade = txtRG.Text;
            fun.Observacoes = txtObservacoes.Text;
            fun.Salario = txtSalario.Text.Replace(".","").Replace("R$","").Replace(",",".");
            fun.Telefone = txtTelefone.Text;
            fun.Sexo = comboSexo.Text;
            fun.Estado_Civil = comboEstadoCivil.Text;
            fun.Qtde_Filhos = comboQtdFilhos.Text;
            fun.Filial = comboFilial.Text;
            fun.Nascimento = txtDataNascimento.Text;
            fun.Email = txtEmail.Text;
            fun.Comissao_Venda = txtComissao.Text.Replace(".", "").Replace("R$", "").Replace(",", ".");

            fun.NumRua = txtNumRua.Text;

            if (checkComissionado.Checked)
                fun.Comissionado = 1;
            else
                fun.Comissionado = 0;

            if (checkAtivo.Checked)
                fun.Ativo = 1;
            else
                fun.Ativo = 0;

            if (checkCadastros.Checked)
                fun.PerCadastro = 1;
            else fun.PerCadastro = 0;

            if (checkMovimento.Checked)
                fun.PerMovimento = 1;
            else fun.PerMovimento = 0;

            if (checkFinanceiro.Checked)
                fun.PerFinanceiro = 1;
            else fun.PerFinanceiro = 0;

            if (checkConfiguracoes.Checked)
                fun.PerConfiguracao = 1;
            else fun.PerConfiguracao = 0;

            if (checkSuperUser.Checked)
                fun.SuperUsuario = 1;
            else fun.SuperUsuario = 0;

            if (checkFilialTodas.Checked)
                fun.Filial_Todas = 1;
            else fun.Filial_Todas = 0;

            return fun;
        }

        private void EntityToTela(Funcionario fun)
        {
            if (fun.Codigo.Equals("1"))
            {
                checkFilialTodas.Enabled = false;
                checkAtivo.Enabled = false;
                checkSuperUser.Enabled = false;
            }
            else
            {
                checkFilialTodas.Enabled = true;
                checkAtivo.Enabled = true;
                checkSuperUser.Enabled = true;
            }
            txtCodigo.Text = fun.Codigo;
            txtNome.Text = fun.Nome;
            txtApelido.Text = fun.Apelido ;
            txtSenha.Text  = fun.Senha ;
            txtBairro.Text = fun.Bairro;
            txtCargo.Text = fun.Cargo;
            txtCelular.Text = fun.Celular;
            txtCep.Text = fun.Cep;
            txtCidade.Text = fun.Cidade;
            txtCLT.Text = fun.Carteira_Trabalho;
            txtCPF.Text = fun.CPF;
            txtDataAdmissao.Text = fun.Admissao;
            txtEndereco.Text = fun.Endereco;
            txtEstado.Text = fun.Estado;
            txtRG.Text = fun.Identidade;
            txtObservacoes.Text = fun.Observacoes;

            txtSalario.Text = fun.Salario;
            MoedaToTxtBox_Salario();
            txtTelefone.Text = fun.Telefone;
            comboSexo.Text = fun.Sexo;
            comboEstadoCivil.Text = fun.Estado_Civil;
            comboQtdFilhos.Text = fun.Qtde_Filhos;
            comboFilial.Text = fun.Filial;
            txtDataNascimento.Text = fun.Nascimento;
            txtEmail.Text = fun.Email;
            txtComissao.Text = fun.Comissao_Venda;
            MoedaToTxtBoxComissao();

            txtNumRua.Text = fun.NumRua;

            if (fun.Comissionado == 1)
                checkComissionado.Checked = true;
            else
                checkComissionado.Checked = false;

            if (fun.Ativo == 1)
                checkAtivo.Checked = true;
            else
                checkAtivo.Checked =false;

            if (fun.PerCadastro == 1)
                checkCadastros.Checked = true;
            else checkCadastros.Checked = false;

            if (fun.PerMovimento == 1)
                checkMovimento.Checked = true;
            else checkMovimento.Checked = false;

            if (fun.PerFinanceiro == 1)
                checkFinanceiro.Checked = true;
            else checkFinanceiro.Checked = false;

            if (fun.PerConfiguracao == 1)
                checkConfiguracoes.Checked = true;
            else checkConfiguracoes.Checked = false;

            if (fun.SuperUsuario == 1)
                checkSuperUser.Checked = true;
            else checkSuperUser.Checked = false;

            if (fun.Filial_Todas == 1)
                checkFilialTodas.Checked = true;
            else checkFilialTodas.Checked = false;
        }

        private void LimpaTela()
        {
            txtApelido.Text = "";
            txtNome.Text = "";
            txtSenha.Text = "";
            txtBairro.Text = "";
            txtCargo.Text = "";
            txtCelular.Text = "";
            txtCep.Text = "";
            txtCidade.Text = "";
            txtCLT.Text = "";
            txtCodigo.Text = "";
            txtCPF.Text = "";
            txtDataAdmissao.Text = DateTime.Now.ToString();
            txtEndereco.Text = "";
            txtEstado.Text = "";
            txtRG.Text = "";
            txtObservacoes.Text = "";
            txtSalario.Text = "";
            txtTelefone.Text = "";
            txtDataNascimento.Text = DateTime.Now.ToString();
            txtEmail.Text = "";
            txtComissao.Text = "";
            txtNumRua.Text = "";

            comboSexo.Text = "";
            comboEstadoCivil.Text = "";
            comboQtdFilhos.Text = "";
            comboFilial.Text = "";

            checkComissionado.Checked = false;
            checkAtivo.Checked = true;
            checkCadastros.Checked = false;
            checkMovimento.Checked = false;
            checkFinanceiro.Checked = false;
            checkConfiguracoes.Checked = false;
            checkSuperUser.Checked = true;
            checkFilialTodas.Checked = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscaCep busca = new BuscaCep(this,null,null,null,null);

            busca.ShowDialog();
        }

        private void MoedaToTxtBox_Salario()
        {
            try
            {
                txtSalario.Text = Convert.ToDouble(txtSalario.Text).ToString("C");
            }

            catch (Exception)
            {

            }
        }

        private void MoedaToTxtBoxComissao()
        {
            try
            {
                txtComissao.Text = Convert.ToDouble(txtComissao.Text).ToString("C");
            }

            catch (Exception)
            {

            }
        }

        private void Salario_Leave(object sender, EventArgs e)
        {
            MoedaToTxtBox_Salario();
        }

        private void Comissao_Leave(object sender, EventArgs e)
        {
            MoedaToTxtBoxComissao();
        }

        private void Salario_KeyPress(object sender, KeyPressEventArgs e)
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
                    if (!txtSalario.Text.Contains(','))
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

        private void Comissao_keyPress(object sender, KeyPressEventArgs e)
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
                    if (!txtComissao.Text.Contains(','))
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

        private void Salario_Enter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= txtSalario.Text.Length - 1; i++)
            {
                if ((txtSalario.Text[i] >= '0' &&
                    txtSalario.Text[i] <= '9') ||
                    txtSalario.Text[i] == ',')
                {
                    x += txtSalario.Text[i];
                }
            }
            txtSalario.Text = x;
            txtSalario.SelectAll();
        }

        private void Comissao_Enter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= txtComissao.Text.Length - 1; i++)
            {
                if ((txtComissao.Text[i] >= '0' &&
                    txtComissao.Text[i] <= '9') ||
                    txtComissao.Text[i] == ',')
                {
                    x += txtComissao.Text[i];
                }
            }
            txtComissao.Text = x;
            txtComissao.SelectAll();
        }
    }
}
