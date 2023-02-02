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
    public partial class CadProdutoTipo : Form
    {
        public CadProdutoTipo()
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

         private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            BuscaProdutos busca = new BuscaProdutos(null,this,null,null, null, null, null, null);
            busca.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!edita)
            {
                CadProdutoT_T_S_BLL BLL = new CadProdutoT_T_S_BLL();
                ProdutoTipo pro = new ProdutoTipo();

                pro = TelaToEntity();

                if (BLL.CadastraProdutoTipo(pro))
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
                DialogResult Result = MessageBox.Show("Realmente deseja Excluir?Caso este tipo tenha sido usado, ao excluir irá provocar inconsistencia no banco de dados, apague somente em caso de cadastro errado e sem uso! ", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.Yes)
                {
                    CadProdutoT_T_S_BLL BLL = new CadProdutoT_T_S_BLL();
                    ProdutoTipo pro = new ProdutoTipo();

                    pro = TelaToEntity();
                    if (BLL.ApagaProdutoTipo(txtCodigo.Text))
                    {
                        MessageBox.Show("Tipo Deletado com Sucesso");
                    }
                    else MessageBox.Show("O Tipo já foi utilizado e não poderá ser excluido");

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
            ProdutoTipo pro = new ProdutoTipo();
          
            pro = TelaToEntity();

            pro = BLL.BuscaAntProdutoTipo(pro);

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
            ProdutoTipo pro = new ProdutoTipo();
           
            pro = TelaToEntity();

            pro = BLL.BuscaProxProdutoTipo(pro);

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
            txtProduto.Text = "";
            checkEpizza.Checked = true;

            edita = false;
        }
        private ProdutoTipo TelaToEntity()
        {
            ProdutoTipo pro = new ProdutoTipo();

            pro.Id = txtCodigo.Text;
            pro.Nome = txtNome.Text;
            pro.CodProduto = txtProduto.Text;

            if (checkEpizza.Checked)
                pro.EPizza = 1;
            else pro.EPizza = 0;

            return pro;
        }

        private void EntityToTela(ProdutoTipo pro)
        {
            txtCodigo.Text = pro.Id;
            txtNome.Text = pro.Nome;
            txtProduto.Text = pro.CodProduto;
            if (pro.EPizza == 1)
                checkEpizza.Checked = true;
            else checkEpizza.Checked = false;
        }


    }
}
