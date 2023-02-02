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
    public partial class CadOperacoes : Form
    {
        public CadOperacoes()
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
            if (!edita)
            {
                CadOperacoesBLL BLL = new CadOperacoesBLL();
                Operacoes op = new Operacoes();
                
                if (!edita)
                {
                    op = TelaToEntity();
                    if (BLL.Cadastra(op))
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
                DialogResult Result = MessageBox.Show("Realmente deseja Excluir? A Exclusão pode ocasionar inconsistencia no Banco de Dados! ", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.Yes)
                {
                    CadOperacoesBLL BLL = new CadOperacoesBLL();
                    Operacoes op = new Operacoes();

                    op = TelaToEntity();
                    if (BLL.Apaga(txtCodigo.Text))
                    {
                        MessageBox.Show("Deletada com Sucesso");
                    }
                    else MessageBox.Show("A Operação já foi utilizada e não poderá ser excluida");

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
            CadOperacoesBLL BLL = new CadOperacoesBLL();
            Operacoes op = new Operacoes();

            op = TelaToEntity();

            op = BLL.BuscaAnt(op);

            if (op != null)
            {
                LimpaTela();
                EntityToTela(op);
            }
            else MessageBox.Show("Erro ao Buscar, Reinicie o Programa, se Persistir entre em contato com o Suporte");
            MensagemErro();
            edita = true;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            CadOperacoesBLL BLL = new CadOperacoesBLL();
            Operacoes op = new Operacoes();

            op = TelaToEntity();

            op = BLL.BuscaProx(op);

            if (op != null)
            {
                LimpaTela();
                EntityToTela(op);
            }
            else MessageBox.Show("Erro ao Buscar, Reinicie o Programa, se Persistir entre em contato com o Suporte");
            MensagemErro();
            edita = true;
        }


        private void LimpaTela()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtCFOP.Text = "";
            txtDescricao.Text = "";
            checkAtivo.Checked = true;
            checkSaída.Checked = true;
            checkEntrada.Checked = false;

            edita = false;
        }
        private Operacoes TelaToEntity()
        {
            Operacoes op = new Operacoes();

            op.Codigo = txtCodigo.Text;
            op.Nome = txtNome.Text;
            op.CFOP = txtCFOP.Text;
            if (checkAtivo.Checked)
                op.Ativo = 1;
            else op.Ativo = 0;

            if (checkSaída.Checked)
                op.Tipo = 1;
            else op.Tipo = 0;
            op.Descricao = txtDescricao.Text;

            return op;
        }

        private void EntityToTela(Operacoes op)
        {
            txtCodigo.Text = op.Codigo;
            txtNome.Text = op.Nome;
            txtCFOP.Text = op.CFOP;

            if (op.Ativo == 1)
                checkAtivo.Checked = true;
            else checkAtivo.Checked = false;
            if (op.Tipo == 1)
            {
                checkEntrada.Checked = false;
                checkSaída.Checked = true;
            }
            else
            {
                checkEntrada.Checked = true;
                checkSaída.Checked = false;
            }
            txtDescricao.Text = op.Descricao;
        }

        private void checkEntrada_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEntrada.Checked)
                checkSaída.Checked = false;
            else checkSaída.Checked = true;
        }

        private void checkSaída_CheckedChanged(object sender, EventArgs e)
        {

            if (checkSaída.Checked)
                checkEntrada.Checked = false;
            else checkEntrada.Checked = true;
        }
    }
}
