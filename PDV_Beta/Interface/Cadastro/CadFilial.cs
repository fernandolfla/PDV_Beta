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

namespace PDV_Beta.Interface
{
    public partial class CadFilial : Form
    {
        public CadFilial()
        {
            InitializeComponent();
        }

        private bool edita = false;
        private void MensagemErro()
        {
            if (Erros.GetHaErro())
            {
                MessageBox.Show(Erros.GetMensagemErro() + " " + Erros.GetErroBanco());
                Erros.SetHaErro(false);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool cnpj = true;
            if (!edita)
            {
                CadFilialBLL BLL = new CadFilialBLL();
                Filial fi = new Filial();

                if (!BLL.ValidaCnpj(txtCNPJ.Text))
                {
                    DialogResult Result = MessageBox.Show("O CNPJ Digitado não é valido, deseja salvar assim mesmo? ", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Result == DialogResult.Yes)
                    {
                        cnpj = true;
                    }
                    else cnpj = false;
                }

                if (cnpj)
                {
                    fi = TelaToEntity();
                    if (BLL.Cadastra(fi))
                    {
                        MessageBox.Show("Cadastro Realizado com Sucesso");
                        LimpaTela();
                    }
                    else
                        MessageBox.Show("Verifique os campos Obrigatórios");
                    MensagemErro();
                }
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (edita)
            {
                DialogResult Result = MessageBox.Show("Realmente deseja Excluir? A Exclusão de uma Filial Como movimento pode ocasionar inconsistencia no Banco de Dados! ", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.Yes)
                {
                    CadFilialBLL BLL = new CadFilialBLL();
                    Filial fi = new Filial();

                    fi = TelaToEntity();
                    if (BLL.Apaga(txtCodigo.Text))
                    {
                        MessageBox.Show("Filial Deletada com Sucesso");
                    }
                    else MessageBox.Show("A Filial já foi utilizada e não poderá ser excluida");

                    LimpaTela();
                    MensagemErro();

                }
            }
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            CadFilialBLL BLL = new CadFilialBLL();
            Filial fi = new Filial();

            fi = TelaToEntity();

            fi = BLL.BuscaAnt(fi);

            if (fi != null)
            {
                LimpaTela();
                EntityToTela(fi);
            }
            else MessageBox.Show("Erro ao Buscar, Reinicie o Programa, se Persistir entre em contato com o Suporte");
            MensagemErro();
            edita = true;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            CadFilialBLL BLL = new CadFilialBLL();
            Filial fi = new Filial();

            fi = TelaToEntity();

            fi = BLL.BuscaProx(fi);

            if (fi != null)
            {
                LimpaTela();
                EntityToTela(fi);
            }
            else MessageBox.Show("Erro ao Buscar, Reinicie o Programa, se Persistir entre em contato com o Suporte");
            MensagemErro();
            edita = true;
        }


        private void LimpaTela()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtCNPJ.Text = "";
            checkAtivo.Checked = true;
            txtEndereco.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtCep.Text = "";
            txtNumRua.Text = "";
            txtInscricao.Text = "";
            txtInscricaoMunicipal.Text = "";
            txtTelefone.Text = "";
            txtTelefone2.Text = "";
            txtEmail.Text = "";
            txtRuaProx.Text = "";
            txtReferencia.Text = "";
            txtObservacoes.Text = "";
            edita = false;
        }
        private Filial TelaToEntity()
        {
            Filial fi = new Filial();

            fi.Codigo = txtCodigo.Text;
            fi.Nome = txtNome.Text;
            fi.CNPJ = txtCNPJ.Text;
            if (checkAtivo.Checked)
                fi.Ativo = 1;
            else fi.Ativo = 0;

            fi.Endereco = txtEndereco.Text;
            fi.Complemento = txtComplemento.Text;
            fi.Bairro = txtBairro.Text;
            fi.Cidade = txtCidade.Text;
            fi.Estado = txtEstado.Text;
            fi.Cep = txtCep.Text;
            fi.NumRua = txtNumRua.Text;
            fi.Inscricao = txtInscricao.Text;
            fi.InscricaoMunicipal = txtInscricaoMunicipal.Text;
            fi.Fone1 = txtTelefone.Text;
            fi.Fone2 = txtTelefone2.Text;
            fi.Email = txtEmail.Text;
            fi.Rua_Proxima1 = txtRuaProx.Text;
            fi.Rua_Proxima2 = txtReferencia.Text;
            fi.Observacoes = txtObservacoes.Text;

            return fi;
        }

        private void EntityToTela(Filial fi)
        {
            txtCodigo.Text = fi.Codigo;
            txtNome.Text = fi.Nome;
            txtCNPJ.Text = fi.CNPJ;

            if (fi.Ativo == 1)
                checkAtivo.Checked = true;
            else checkAtivo.Checked = false;

            txtEndereco.Text = fi.Endereco;
            txtComplemento.Text = fi.Complemento;
            txtBairro.Text = fi.Bairro;
            txtCidade.Text = fi.Cidade;
            txtEstado.Text = fi.Estado;
            txtCep.Text = fi.Cep;
            txtNumRua.Text = fi.NumRua;
            txtInscricao.Text = fi.Inscricao;
            txtInscricaoMunicipal.Text = fi.InscricaoMunicipal;
            txtTelefone.Text = fi.Fone1;
            txtTelefone2.Text = fi.Fone2;
            txtEmail.Text = fi.Email;
            txtRuaProx.Text = fi.Rua_Proxima1;
            txtReferencia.Text = fi.Rua_Proxima2;
            txtObservacoes.Text = fi.Observacoes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscaCep busca = new BuscaCep(null, null, null,this,null);

            busca.ShowDialog();
        }
    }
}
