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
    public partial class CadProdutoTamanho : Form
    {
        public CadProdutoTamanho()
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
                CadProdutoT_T_S_BLL BLL = new CadProdutoT_T_S_BLL();
                ProdutoTamanho pro = new ProdutoTamanho();

                pro = TelaToEntity();

                if (BLL.CadastraProdutoTamanho(pro))
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
                DialogResult Result = MessageBox.Show("Realmente deseja Excluir?Caso este Tamanho tenha sido usado, ao excluir irá provocar inconsistencia no banco de dados, apague somente em caso de cadastro errado e sem uso! ", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.Yes)
                {
                    CadProdutoT_T_S_BLL BLL = new CadProdutoT_T_S_BLL();
                    ProdutoTamanho pro = new ProdutoTamanho();

                    pro = TelaToEntity();
                    if (BLL.ApagaProdutoTamanho(txtCodigo.Text))
                    {
                        MessageBox.Show("Tamanho Deletado com Sucesso");
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
            CadProdutoT_T_S_BLL BLL = new CadProdutoT_T_S_BLL();
            ProdutoTamanho pro = new ProdutoTamanho();

            pro = TelaToEntity();

            pro = BLL.BuscaAntProdutoTamanho(pro);

            if (pro != null)
            {
                LimpaTela();
                EntityToTela(pro);
            }
            else MessageBox.Show("Erro ao Buscar, Reinicie o Programa, se Persistir entre em contato com o Suporte");
            MensagemErro();
            edita = true;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            CadProdutoT_T_S_BLL BLL = new CadProdutoT_T_S_BLL();
            ProdutoTamanho pro = new ProdutoTamanho();

            pro = TelaToEntity();

            pro = BLL.BuscaProxProdutoTamanho(pro);

            if (pro != null)
            {
                LimpaTela();
                EntityToTela(pro);
            }
            else MessageBox.Show("Erro ao Buscar, Reinicie o Programa, se Persistir entre em contato com o Suporte");
            MensagemErro();
            edita = true;
        }









        private void LimpaTela()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtQtdPedacos.Text = "";
            txtQtdSabor.Text = "";

            edita = false;
        }
        private ProdutoTamanho TelaToEntity()
        {
            ProdutoTamanho pro = new ProdutoTamanho();

            pro.Id = txtCodigo.Text;
            pro.Nome = txtNome.Text;
            pro.QtdPedacos = txtQtdPedacos.Text;
            pro.QtdSabores = txtQtdSabor.Text;

            return pro;
        }

        private void EntityToTela(ProdutoTamanho pro)
        {
            txtCodigo.Text = pro.Id;
            txtNome.Text = pro.Nome;
            txtQtdPedacos.Text = pro.QtdPedacos;
            txtQtdSabor.Text = pro.QtdSabores;
        }

     



    }
}
