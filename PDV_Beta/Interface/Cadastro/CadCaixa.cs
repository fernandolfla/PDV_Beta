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
    public partial class CadCaixa : Form
    {
        public CadCaixa()
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
                CadCaixaBLL BLL = new CadCaixaBLL();
                Caixa cx = new Caixa();

                cx = TelaToEntity();

                if (BLL.CadastraCaixa(cx))
                {
                    MessageBox.Show("Cadastro Realizado com Sucesso");
                    LimpaTela();
                }
                else
                    MessageBox.Show("Verifique os campos Obrigatórios");

                MensagemErro();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (edita)
            {
                DialogResult Result = MessageBox.Show("Realmente deseja Excluir?Caso este Caixa Possua Movimento, ao excluir irá provocar inconsistencia no banco de dados, apague somente em caso de cadastro errado e sem uso! ", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.Yes)
                {
                    CadCaixaBLL BLL = new CadCaixaBLL();
                    Caixa cx = new Caixa();

                    cx = TelaToEntity();
                    if (BLL.ApagaCaixa(txtCodigo.Text))
                    {
                        MessageBox.Show("Caixa Deletado com Sucesso");
                    }
                    else MessageBox.Show("O Tamanho já foi utilizado e não poderá ser excluido");

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
            CadCaixaBLL BLL = new CadCaixaBLL();
            Caixa cx = new Caixa();

            cx = TelaToEntity();

            cx = BLL.BuscaAntCaixa(cx);

            if (cx != null)
            {
                LimpaTela();
                EntityToTela(cx);
            }
            else MessageBox.Show("Erro ao Buscar, Reinicie o Programa, se Persistir entre em contato com o Suporte");
            MensagemErro();
            edita = true;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            CadCaixaBLL BLL = new CadCaixaBLL();
            Caixa cx = new Caixa();

            cx = TelaToEntity();

            cx = BLL.BuscaProxCaixa(cx);

            if (cx != null)
            {
                LimpaTela();
                EntityToTela(cx);
            }
            else MessageBox.Show("Erro ao Buscar, Reinicie o Programa, se Persistir entre em contato com o Suporte");
            MensagemErro();
            edita = true;
        }

        private void btnProxCodLivre_Click(object sender, EventArgs e)
        {
            if (!edita)
            {
                CadCaixaBLL BLL = new CadCaixaBLL();

                txtCodigo.Text = BLL.BuscaProxCodLivre();
            }
            MensagemErro();
        }

        private void LimpaTela()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtDescricao.Text = "";
            checAtivo.Checked = true;

            edita = false;
        }
        private Caixa TelaToEntity()
        {
            Caixa cx = new Caixa();

            cx.Id = txtCodigo.Text;
            cx.Nome = txtNome.Text;
            cx.Descicao = txtDescricao.Text;
            if (checAtivo.Checked)
                cx.Ativo = 1;
            else cx.Ativo = 0;

            return cx;
        }

        private void EntityToTela(Caixa cx)
        {
            txtCodigo.Text = cx.Id;
            txtNome.Text = cx.Nome;
            txtDescricao.Text = cx.Descicao;

            if (cx.Ativo == 1)
                checAtivo.Checked = true;
            else checAtivo.Checked = false;
        }

      
    }
}
